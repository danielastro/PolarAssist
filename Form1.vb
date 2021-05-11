Public Class Form1

    Public objtelescope As ASCOM.DriverAccess.Telescope
    Public MountSideofPier As ASCOM.DeviceInterface.PierSide

    Dim FinalRa As Double 'RA where the scope will slew
    Dim FinalDec As Double 'DEC where the Scope will slew
    Dim SlewNoRotate As Boolean = True ' Allows to chose slew method 
    Dim Statustracking As Boolean = False 'To follow If scope Is tracking

    Public SettingAngle As Double = My.Settings.AngleSetting ' Default angle of the Bulleye on the Polarscope at NCP
    Public AllowPastHorizon As Double = My.Settings.PastHorizon 'how many degrees past horizon do you allow slew
    Public CurrentBullseyePos As Double = 0 'Current position of the bullseye on the polarscope 
    Public TargetedBullseye As Double ' Angle where the Bullseye has to be
    Public TargetMountAngle As Double 'Angle of the scope to get the targeted bullseye
    Public MountAngle As Double ' current angle of the scope im degrees

    Dim CWDistance As Double
    Dim CCWDistance As Double
    Dim RotateAngle As Double
    Dim RotateDirection As String

    Dim TargetAZI As Integer
    Dim TargetALT As Integer

    Dim TargetRA As Double
    Dim TargetDec As Double


    Public PolarisRAJNow As Double = 44.52383333 'Constant
    'Dim PolarisDecJNow As Double = 89.35213889  'Constant
    'Dim PolarisRAJ2000 As Double = 37.9637083   'Constant
    'Dim PolarisDecJ2000 As Double = 89.2643056  'Constant


    Public LSidereal As Double 'Local Sidereal Time
    Dim Polarishourangle As Double ' Hour Angle of Polaris based on Local Sidereal Time
    Public SiteLong As Double
    Public SiteLat As Double
    Public MountRA As Double
    Public MountDec As Double

    Dim Epoch2000 As Date 'Epoch J2000 is jan 1st 2000 at noon
    Dim Epochmaintenant As Date
    Dim Tspan As TimeSpan
    Dim Days2000 As Double 'Days since Jan 1st 2000 Noon

    ReadOnly OriginalImage As Bitmap = My.Resources.PolarScreen 'Image with Target at 0 degree
    Dim Bmp As Bitmap 'Used to receive turned image from RotateImage
    Public Shared Function Range360(x)
        'Function makes sure degrees are always between 0 and 359.99
        Range360 = x - 360 * Int(x / 360)
    End Function
    Public Function DDtohms(Digitalhr, TorD)
        'Converts RA expressed As degrees(360) To the 24 hour format
        'Divide RA In 360 degrees by 15 To Get 24 hrs format
        'TorD = 1 for HH:mm:ss
        'TorD = 2 for Degrees Min Sec
        'TorD = 3 for Degrees Only
        Dim Dighr As Double
        Dim Digmi As Double
        Dim Digse As Double
        Dim Sighr As String
        Dim Sigmi As String
        Dim Sigse As String

        If Digitalhr < 0 Then
            Digitalhr *= -1 'make it positive but revert it further
            Dighr = Math.Floor(Digitalhr)
            If Dighr < 10 Then
                Sighr = "0" & Dighr
            Else
                Sighr = Dighr
            End If
            Sighr = String.Concat("-", Sighr)
        Else
            Dighr = Math.Floor(Digitalhr)
            If Dighr < 10 And TorD <> 3 Then
                Sighr = "0" & Dighr
            Else
                Sighr = Dighr
            End If
        End If

        Digmi = Math.Floor((Digitalhr - Dighr) * 60)

        If Digmi < 10 Then
            Sigmi = "0" & Digmi
        Else
            Sigmi = Digmi
        End If

        Digse = Math.Floor((((Digitalhr - Dighr) * 60) - Digmi) * 60)
        If Digse < 10 Then
            Sigse = "0" & Digse
        Else
            Sigse = Digse
        End If

        If TorD = 1 Then
            DDtohms = String.Concat(Sighr, ":", Sigmi, ":", Sigse)
        ElseIf TorD = 3 Then
            DDtohms = String.Concat(Math.Round(Digitalhr), Chr(176))
        Else
            DDtohms = String.Concat(Sighr, Chr(176), " ", Sigmi, Chr(39), " ", Sigse, Chr(34))
        End If

    End Function
    Public Shared Function Gst(days As Double) As Double
        ' returns siderial time at longitude zero given days after J2000.0
        Dim T As Double
        T = days / 36525
        Gst = 280.46061837 + (360.98564736629 * days)
        Gst = Gst + (0.000387933 * (T ^ 2)) - (T ^ 3) / 38710000
        Gst = Range360(Gst)
    End Function
    Public Function RotateImage(img As Image, angle As Single) As Bitmap
        ' the calling code is responsible for (and must) 
        ' disposing of the bitmap returned

        Dim retBMP As New Bitmap(img.Width, img.Height)
        retBMP.SetResolution(img.HorizontalResolution, img.VerticalResolution)

        Using g = Graphics.FromImage(retBMP)
            ' rotate aroung the center of the image
            g.TranslateTransform(img.Width \ 2, img.Height \ 2)

            'rotate
            g.RotateTransform(angle)

            g.TranslateTransform(-img.Width \ 2, -img.Height \ 2)

            'draw image to the bitmap
            g.DrawImage(img, New PointF(0, 0))

            Return retBMP
        End Using
    End Function
    Public Sub Form1_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Sub runs at opening of form, shows 
        CurrentBullseyePos = SettingAngle 'Before connection, just show default setting for Target Position

        Bmp = RotateImage(OriginalImage, CurrentBullseyePos)
        PictureBox1.Image = Bmp
        TBTelescope.Text = My.Settings.Telescope
        TBCurrentBullseye.Text = DDtohms(CurrentBullseyePos, 3)
        ReadytoConnect()

    End Sub
    Public Sub WhereisBullseye()
        'Calculates current bullseye position , displays it and rotates image
        'also calculates MOUNT Angle
        MountSideofPier = objtelescope.SideOfPier

        MountRA = objtelescope.RightAscension * 15
        MountDec = objtelescope.Declination
        TBRa.Text = DDtohms(MountRA / 15, 1)
        TBDec.Text = DDtohms(MountDec, 2)

        TBAltitude.Text = DDtohms(objtelescope.Altitude, 2)
        TBAzimuth.Text = DDtohms(objtelescope.Azimuth, 2)

        If MountSideofPier = 0 Then
            TBSideofpier.Text = "Pier East"
            MountAngle = Range360(MountRA - LSidereal + 90)
            CurrentBullseyePos = Range360(MountAngle + SettingAngle)

        Else
            TBSideofpier.Text = "Pier West"
            MountAngle = Range360(MountRA - LSidereal - 90)
            CurrentBullseyePos = Range360(MountAngle + SettingAngle)

        End If
        TBMountAngle.Text = DDtohms(MountAngle, 3)
        Bmp = RotateImage(OriginalImage, CurrentBullseyePos)
        PictureBox1.Image = Bmp

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'Timer 2 runs all the time to update the clock
        TBLocalTime.Text = DateTime.Now
        TBUtc.Text = DateTime.UtcNow
        Epoch2000 = DateSerial(2000, 1, 1).AddDays(0.5) 'Epoch J2000 is jan 1st 2000 at noon
        Epochmaintenant = DateTime.UtcNow
        Tspan = Epochmaintenant - Epoch2000 'time span between jan 1 2000 nooon and now
        Days2000 = Tspan.TotalDays 'Days since Jan 1st 2000 Noon
        TBJ2000.Text = Math.Round(Days2000, 4)
        TBMSidereal.Text = DDtohms(Gst(Days2000) / 15, 1) 'Sidereal Time at Longitude 0 (Greenwitch)
    End Sub
    Private Sub BTNSelect_Click(sender As Object, e As EventArgs) Handles BTNSelect.Click
        'Ascom Sub to chose the Ascom Scope
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "Telescope"

        'Text Box TBTelescope displays the chosen scope
        Try
            My.Settings.Telescope = obj.Choose(My.Settings.Telescope)
            TBTelescope.Text = My.Settings.Telescope
            ' If telescope is chosen, enable next set of buttons
            ReadytoConnect()

        Catch ex As System.NullReferenceException
            MessageBox.Show("Problem Connecting, Check selection")

        End Try

    End Sub
    Public Sub ReadytoConnect() ' to change button color and availability when not connected
        If My.Settings.Telescope <> "" Then
            BTNConnect.Enabled = True
            BTNConnect.BackColor = Color.LimeGreen
            BTNSelect.Enabled = True
            BTNSelect.BackColor = Color.Gold
        Else
            BTNConnect.Enabled = False
            BTNConnect.BackColor = Color.Red
            BTNSelect.BackColor = Color.LimeGreen
        End If
    End Sub
    Public Sub ScopeConnected()
        'Sub runs when the scope gets connected
        Timer1.Enabled = True

        BTNDisconnect.Enabled = True
        BTNDisconnect.BackColor = Color.LimeGreen

        BTNConnect.Enabled = False
        BTNConnect.BackColor = Color.Red
        'Disable Select button
        BTNSelect.Enabled = False
        BTNSelect.BackColor = Color.Red

        BTSlewRight.Enabled = True
        BTSlewLeft.Enabled = True
        BTNAbort.Enabled = True
        Form2.BTAutoSetTop.Enabled = True
        Form2.BTAutoSetBottom.Enabled = True
        Form2.BTSlewLeft.Enabled = True
        Form2.BTSlewRight.Enabled = True


    End Sub
    Public Sub ScopeDisconnected()
        'Sub runs when Scope gets disconnected
        Timer1.Enabled = False

        BTNDisconnect.BackColor = Color.Red
        BTNDisconnect.Enabled = False

        BTNConnect.Enabled = True
        BTNConnect.BackColor = Color.LimeGreen
        'also remove tracking and slewing status
        CBTracking.Checked = False
        CBSlewing.Checked = False

        BTNSlew.Enabled = False
        BTNSlew.BackColor = Color.Red
        BTNAbort.Enabled = False
        BTNAbort.BackColor = Color.Silver

        BTNSelect.Enabled = True
        BTNSelect.BackColor = Color.Gold

        BTSlewRight.Enabled = False
        BTSlewLeft.Enabled = False

        Form2.BTAutoSetTop.Enabled = False
        Form2.BTAutoSetBottom.Enabled = False
        Form2.BTSlewLeft.Enabled = False
        Form2.BTSlewRight.Enabled = False

    End Sub
    Private Sub BTNConnect_Click(sender As Object, e As EventArgs) Handles BTNConnect.Click
        'This connects to the chosen scope
        Try
            objtelescope = New ASCOM.DriverAccess.Telescope(My.Settings.Telescope)
            objtelescope.Connected = True

        Catch ex As Exception
            MessageBox.Show("Problem Connecting, Check selection")

        End Try
        If objtelescope.Connected = True Then
            ScopeConnected()
            'Get latlong from Mount
            Getlatlong()
            objtelescope.SlewSettleTime = 3

        End If

    End Sub
    Private Sub BTNDisconnect_Click(sender As Object, e As EventArgs) Handles BTNDisconnect.Click
        'Sub runs when Disconnect Button is chosen
        ScopeDisconnected()
        objtelescope.Connected = False


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer routine to update fields when scope is connected
        If objtelescope.Tracking = True Then
            CBTracking.Checked = True
            Statustracking = True
        Else
            CBTracking.Checked = False
            Statustracking = False
        End If

        If objtelescope.Slewing = True Then
            CBSlewing.Checked = True
        Else
            CBSlewing.Checked = False
            BTNAbort.BackColor = Color.Silver
        End If
        PolarisHR()
        WhereisBullseye()
        SleworRotate()


    End Sub
    Public Sub PolarisHR()
        'this gets polaris HA and therefore Bullseye Position
        LSidereal = Range360(Gst(Days2000) + SiteLong)
        TBLSidereal.Text = DDtohms(LSidereal / 15, 1)
        Polarishourangle = Range360((LSidereal - PolarisRAJNow))
        TBPolarisHA.Text = DDtohms(Polarishourangle / 15, 1)

    End Sub
    Public Sub SleworRotate()
        'This subroutine decides if the scope can slew to the bullseye or if manual slew is required
        'first by testing the mount angle at destination
        TargetedBullseye = Range360(360 - (Polarishourangle + 180))  ' plus 180 because scope inverts image
        TBTargetBullseye.Text = DDtohms(TargetedBullseye, 3)
        TBCurrentBullseye.Text = DDtohms(CurrentBullseyePos, 3)
        CCWDistance = Range360(CurrentBullseyePos - TargetedBullseye)
        CWDistance = Range360(TargetedBullseye - CurrentBullseyePos)
        TBCCWDisttoTarget.Text = DDtohms(CCWDistance, 3)
        TBCWDisttoTarget.Text = DDtohms(CWDistance, 3)

        ' now that distance is known, lets find direction
        If Math.Abs(CCWDistance) < Math.Abs(CWDistance) Then
            RotateDirection = "CCW"
            'RotateAngle = CCWDistance
            RotateAngle = Math.Abs(CCWDistance)
            TargetMountAngle = Range360(MountAngle - RotateAngle)
            TBCWDisttoTarget.BackColor = Color.White
            TBCCWDisttoTarget.BackColor = Color.LimeGreen
        Else
            RotateDirection = "CW"
            'RotateAngle = CWDistance
            RotateAngle = Math.Abs(CWDistance)
            TargetMountAngle = Range360(MountAngle + RotateAngle)
            TBCWDisttoTarget.BackColor = Color.LimeGreen
            TBCCWDisttoTarget.BackColor = Color.White
        End If

        ' if target mount angle is too far, cannot slew
        If TargetMountAngle > 90 And TargetMountAngle < 270 Then
            'cannot slew if destination is 
            ' insert here code to bring mount close and allow rotate
            If TargetMountAngle < 90 Then
                TargetAZI = 270
            ElseIf TargetMountAngle > 270 Then
                TargetAZI = 90
            End If
            TargetALT = 3 'on the horizon

            ' convert the target ALT AZ ro RA DEC and then add Hour Angle to find Final RADEC
            TargetDec = Astroformulas.RADec(Days2000, TargetALT, TargetAZI, SiteLat, SiteLong, 2)
            TargetRA = Astroformulas.RADec(Days2000, TargetALT, TargetAZI, SiteLat, SiteLong, 1)
            FinalRa = TargetRA
            SlewNoRotate = False

        ElseIf TargetMountAngle <= 90 Then   'Can Slew to Bulseye
            TargetAZI = 270
            TargetALT = 3 'on the horizon

            ' convert the target ALT AZ ro RA DEC and then add Hour Angle to find Final RADEC
            TargetDec = Astroformulas.RADec(Days2000, TargetALT, TargetAZI, SiteLat, SiteLong, 2)
            TargetRA = Astroformulas.RADec(Days2000, TargetALT, TargetAZI, SiteLat, SiteLong, 1)

            If RotateDirection = "CW" Then
                'add Rotate angle 
                FinalRa = Range360(MountRA + RotateAngle)  'Clockwise
                SlewNoRotate = True
            Else 'Rotate is CCW
                'substract Rotate angle . 
                FinalRa = Range360(MountRA - RotateAngle)  'counterClockwise
                SlewNoRotate = True
            End If

        Else ' Targetmountangle 270 degrees
            TargetAZI = 90
            TargetALT = 3 'on the horizon

            ' convert the target ALT AZ ro RA DEC and then add Hour Angle to find Final RADEC
            TargetDec = Astroformulas.RADec(Days2000, TargetALT, TargetAZI, SiteLat, SiteLong, 2)
            TargetRA = Astroformulas.RADec(Days2000, TargetALT, TargetAZI, SiteLat, SiteLong, 1)

            If RotateDirection = "CW" Then
                'add Distance angle
                FinalRa = Range360(MountRA + RotateAngle)  'Clockwise
                SlewNoRotate = True
            Else 'Rotate is CCW
                'Substract Distance angle
                FinalRa = Range360(MountRA - RotateAngle)  'counterClockwise
                SlewNoRotate = True
            End If

        End If


        FinalDec = TargetDec
        TBFinalDec.Text = DDtohms(FinalDec, 2)
        TBFinalRa.Text = DDtohms(FinalRa / 15, 1)

        If SlewNoRotate = False Then
            'Cannot use Slew, Use Manual Rotate
            BTNSlew.Enabled = False
            BTNSlew.BackColor = Color.Red
            'BTNAbort.Enabled = False
            'BTNAbort.BackColor = Color.Silver
            LBCannotSlew.Visible = True
            BTRotate.BackColor = Color.LimeGreen
            BTRotate.Enabled = True
            'bring the mount the closest possible to  the bullseye
        Else
            'Enable button to slew to bullseye
            BTNSlew.Enabled = True
            BTNSlew.BackColor = Color.LimeGreen
            'Enable abort button
            'BTNAbort.BackColor = Color.Silver
            'BTNAbort.Enabled = True
            LBCannotSlew.Visible = False
            BTRotate.BackColor = Color.Red
            BTRotate.Enabled = False

        End If

    End Sub
    Private Sub Getlatlong()
        ' Store Mount longitude in SiteLong 
        SiteLong = objtelescope.SiteLongitude
        SiteLat = objtelescope.SiteLatitude
        TBScopeLat.Text = DDtohms(SiteLat, 2)
        TBScopeLong.Text = DDtohms(SiteLong, 2)
    End Sub
    Private Sub BTNSlew_click(sender As Object, e As EventArgs) Handles BTNSlew.Click

        If Statustracking = True Then
            objtelescope.Tracking = True

            objtelescope.TargetRightAscension = FinalRa / 15
            objtelescope.TargetDeclination = FinalDec
            objtelescope.SlewToTargetAsync()
            BTNAbort.BackColor = Color.Yellow
        Else
            MessageBox.Show("Cannot slew if Scope is not tracking")
        End If

    End Sub
    Private Sub BTRotate_Click(sender As Object, e As EventArgs) Handles BTRotate.Click
        If Statustracking = True Then
            objtelescope.TargetRightAscension = FinalRa / 15
            objtelescope.TargetDeclination = FinalDec
            objtelescope.SlewToTargetAsync()
            BTNAbort.BackColor = Color.Yellow
        Else
            MessageBox.Show("Cannot Rotate if Scope is not tracking")
        End If
    End Sub
    Private Sub BTNAbort_Click(sender As Object, e As EventArgs) Handles BTNAbort.Click
        objtelescope.AbortSlew()
        sender.enabled = True
        BTNAbort.BackColor = Color.Red
    End Sub
    Private Sub BTNExit_Click(sender As Object, e As EventArgs) Handles BTNExit.Click
        Application.Exit()
        End
    End Sub
    Private Sub BTConfigure_Click(sender As Object, e As EventArgs) Handles BTConfigure.Click
        'Dim box = New Form2()
        'box.Show()
        Form2.Show()
    End Sub
    Private Sub BTSlewLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles BTSlewLeft.MouseDown
        objtelescope.MoveAxis(0, -4)
    End Sub
    Private Sub BTSlewLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles BTSlewLeft.MouseUp
        objtelescope.MoveAxis(0, 0)
    End Sub
    Private Sub BTSlewRight_MouseDown(sender As Object, e As MouseEventArgs) Handles BTSlewRight.MouseDown
        objtelescope.MoveAxis(0, 4)
    End Sub
    Private Sub BTSlewRight_MouseUp(sender As Object, e As MouseEventArgs) Handles BTSlewRight.MouseUp
        objtelescope.MoveAxis(0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim NCPAzimuth As Double = 0.0000005
        objtelescope.Tracking = False
        objtelescope.SlewToAltAzAsync(NCPAzimuth, SiteLat)

    End Sub
End Class

Public Class Astroformulas
    Public Const PI As Double = 3.14159265358979
    Public Const tpi As Double = 6.28318530717958
    Public Const degs As Double = 57.2957795130823
    Public Const rads As Double = 0.0174532925199433

    ' Returns days after 12:00 1/1/2000, greg switch for Gregorian or
    ' Julian calendar - default is Gregorian.
    ' passing values from Form1

    'ex : TBJ2000.Text = astroformulas.Days2000(2021, 3, 5, 19, 0, 0)
    Public Shared Function Days2000(year As Integer, month As Integer, day As Integer,
    hour As Integer, min As Integer, sec As Double) As Double
        Dim a As Double
        Dim B As Integer
        'a = 10000.0# * year + 100.0# * month + day
        If (month <= 2) Then
            month += 12
            year = year - 1
        End If

        B = Fix(year / 400) - Fix(year / 100) + Fix(year / 4)
        a = 365.0# * year - 730548.5
        Days2000 = a + B + Fix(30.6001 * (month + 1))
        Days2000 = Days2000 + day + (hour + min / 60 + sec / 3600) / 24

    End Function



    Public Shared Function Altaz(d As Double, DEC As Double, RA As Double, GLat As Double, GLong As Double, Index As Integer) As Double
        'Attribute altaz.VB_Description = "' returns altitude and azimuth of object given RA and DEC of\r\n' object, latitude and longitude of observer and days after\r\n' J2000.0 Index = 1 for altitude and 2 for azimuth"
        Dim h As Double, a As Double, sa As Double, cz As Double
        h = Form1.Gst(d) + GLong - RA
        sa = DegSin(DEC) * DegSin(GLat)
        sa = sa + DegCos(DEC) * DegCos(GLat) * DegCos(h)
        a = DegArcsin(sa)
        cz = DegSin(DEC) - DegSin(GLat) * sa
        cz = cz / (DegCos(GLat) * DegCos(a))
        Select Case Index
            Case 1  'altitude
                Altaz = a
            Case 2  'azimuth
                If DegSin(h) < 0 Then
                    Altaz = DegArccos(cz)
                Else
                    Altaz = 360 - DegArccos(cz)
                End If
        End Select
        Return Altaz

    End Function

    Public Shared Function RADec(Day2000 As Double, Alt As Double, Az As Double, GLat As Double, GLong As Double, Index As Integer) As Double
        ' returns the RA and Dec from the Alt Az coordinates in degrees
        ' where ...
        ' Day2000 is the J2000 date and fraction of a date
        ' Alt is altitude in degrees
        ' Az is azimuth in degrees
        ' GLat is the observers latitude in degrees
        ' GLong is the observers longitude in degrees
        ' Index = 1 for RA and 2 for Dec


        'DEPENDENCIES
        ' degarcsin()
        ' degsin()
        ' degcos()
        ' degarccos()

        'Declination, DEC, must be solved first because it is used to find hour angle, H.

        'sin DEC = sin LAT sin ALT + cos LAT cos ALT cos AZ

        'cos H = (sin ALT - sin DEC sin LAT)/(cos DEC cos L'AT)
        'The arc cos function may be used to find H.
        'H = LST - RA    therefore  RA = LST - H

        Dim temp As Double
        Dim DEC As Double
        temp = DegSin(GLat) * DegSin(Alt) + DegCos(GLat) * DegCos(Alt) * DegCos(Az)
        DEC = DegArcsin(temp)
        'temp = 0
        temp = (DegSin(Alt) - DegSin(DEC) * DegSin(GLat)) / (DegCos(DEC) * DegCos(GLat))
        temp = DegArccos(temp)
        Dim RA As Double
        If Az < 180 Then

            RA = Form1.Range360(Form1.Gst(Day2000) + GLong + temp)
        Else
            RA = Form1.Range360(Form1.Gst(Day2000) + GLong - temp)
        End If

        'If RA < 0 Then
        ' RA = RA + 360
        ' End If

        If Index = 1 Then
            RADec = RA
        Else
            RADec = DEC
        End If

    End Function

    Public Shared Function DegSin(x As Double) As Double
        DegSin = Math.Sin(rads * x)
    End Function

    Public Shared Function DegCos(x As Double) As Double
        DegCos = Math.Cos(rads * x)
    End Function

    Public Shared Function DegTan(x As Double) As Double
        DegTan = Math.Tan(rads * x)
    End Function

    Public Shared Function DegArcsin(x As Double) As Double
        DegArcsin = degs * Math.Asin(x)
    End Function

    Public Shared Function DegArccos(x As Double) As Double
        DegArccos = degs * Math.Acos(x)
    End Function

    Public Shared Function DegArctan(x As Double) As Double
        DegArctan = degs * Math.Atan(x)
    End Function



End Class