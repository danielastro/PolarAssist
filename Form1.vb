Public Class Form1

    Public objtelescope As ASCOM.DriverAccess.Telescope
    Public MountSideofPier As ASCOM.DeviceInterface.PierSide

    Dim FinalRa As Double 'RA where the scope will slew
    Dim FinalDec As Double 'DEC where the Scope will slew
    Dim Statustracking As Boolean = False 'To follow If scope Is tracking

    Public MountAngle As Double ' current angle of the scope im degrees

    Public LSidereal As Double 'Local Sidereal Time
    Public SiteLong As Double
    Public SiteLat As Double
    Public MountRA As Double
    Public MountDec As Double
    Public MountAltitude As Double
    Public MountAzimuth As Double
    Public MountSiderealTime As Double

    Dim TenthSec As Integer = 0

    Dim Epoch2000 As Date 'Epoch J2000 is jan 1st 2000 at noon
    Dim Epochmaintenant As Date
    Dim Tspan As TimeSpan
    Dim Days2000 As Double 'Days since Jan 1st 2000 Noon

    Public Shared Function Range360(x)
        'Function makes sure degrees are always between 0 and 359.99
        Range360 = x - 360 * Int(x / 360)
    End Function
    Public Shared Function DDtohms(Digitalhr, TorD)
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
    Public Sub Form1_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Sub runs at opening of form, shows 

        TBTelescope.Text = My.Settings.Telescope
        TBTargetAltitude.Text = DDtohms(My.Settings.FlatAltitude, 2)
        TBTargetAzimuth.Text = DDtohms(My.Settings.FlatAzimuth, 2)

        ReadytoConnect()

    End Sub
    Public Sub WhereisMount()
        'Calculates current Mount position , displays it
        'also calculates MOUNT Angle
        'Runs when timer1 is enabled
        MountSideofPier = objtelescope.SideOfPier

        MountRA = objtelescope.RightAscension * 15
        MountDec = objtelescope.Declination
        TBRa.Text = DDtohms(MountRA / 15, 1)
        TBDec.Text = DDtohms(MountDec, 2)

        MountAltitude = objtelescope.Altitude
        MountAzimuth = objtelescope.Azimuth
        TBAltitude.Text = DDtohms(objtelescope.Altitude, 2)
        TBAzimuth.Text = DDtohms(objtelescope.Azimuth, 2)
        Form2.CurAlt.Text = DDtohms(objtelescope.Altitude, 2)
        Form2.CurAz.Text = DDtohms(objtelescope.Azimuth, 2)

        If MountSideofPier = 0 Then
            TBSideofpier.Text = "Pier East"
            MountAngle = Range360(MountRA - LSidereal + 90)

        Else
            TBSideofpier.Text = "Pier West"
            MountAngle = Range360(MountRA - LSidereal - 90)

        End If
        TBMountAngle.Text = DDtohms(MountAngle, 3)

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick 'Timer 2 runs all the time to update the clock
        TBLocalTime.Text = DateTime.Now
        TBUtc.Text = DateTime.UtcNow
        Epoch2000 = DateSerial(2000, 1, 1).AddDays(0.5) 'Epoch J2000 is jan 1st 2000 at noon
        Epochmaintenant = DateTime.UtcNow
        Tspan = Epochmaintenant - Epoch2000 'time span between jan 1 2000 noon and now
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

            Form2.BTGetAltAz.Enabled = False
            Form2.BTGetAltAz.BackColor = Color.Red
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

        Form2.BTSlewRight.Enabled = True
        Form2.BTSlewLeft.Enabled = True
        Form2.BTSlewUp.Enabled = True
        Form2.BTSlewDown.Enabled = True

        BTNAbort.Enabled = True
        BTNSlew.Enabled = True
        BTNSlew.BackColor = Color.LimeGreen

        Form2.BTGetAltAz.Enabled = True
        Form2.BTGetAltAz.BackColor = Color.LimeGreen


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

        Form2.BTGetAltAz.Enabled = False
        Form2.BTGetAltAz.BackColor = Color.Red

        Form2.BTSlewRight.Enabled = False
        Form2.BTSlewLeft.Enabled = False
        Form2.BTSlewUp.Enabled = False
        Form2.BTSlewDown.Enabled = False

        TBLSidereal.Text = ""
        TBMountSidereal.Text = ""
        TBRa.Text = ""
        TBDec.Text = ""
        TBAltitude.Text = ""
        TBAzimuth.Text = ""
        TBMountAngle.Text = ""
        TBSideofpier.Text = ""
        Form2.CurAlt.Text = ""
        Form2.CurAz.Text = ""


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
            'Try
            'objtelescope.SlewSettleTime = 3  ' not implemented in CPWI Need to work on catching exception
            'Catch ex As Exception
            'MessageBox.Show("cannot set settle time " & ex.Message, "Error Message")
            ' End Try
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
        MountHR()
        WhereisMount()


    End Sub
    Public Sub MountHR()
        'this gets Mount and Local SiderealTime 
        LSidereal = Range360(Gst(Days2000) + SiteLong)
        TBLSidereal.Text = DDtohms(LSidereal / 15, 1)
        MountSiderealTime = objtelescope.SiderealTime
        TBMountSidereal.Text = DDtohms(MountSiderealTime, 1)
    End Sub
    Private Sub Getlatlong()
        ' Store Mount longitude in SiteLong 
        SiteLong = objtelescope.SiteLongitude
        SiteLat = objtelescope.SiteLatitude
        TBScopeLat.Text = DDtohms(SiteLat, 2)
        TBScopeLong.Text = DDtohms(SiteLong, 2)
    End Sub
    Private Sub BTNSlew_click(sender As Object, e As EventArgs) Handles BTNSlew.Click
        ' turn on tracking if not
        If Statustracking = False Then
            objtelescope.Tracking = True
        End If

        ' convert the Flat Panel ALT AZ to RA DEC and then slew to Flat Position
        FinalDec = Astroformulas.RADec(Days2000, My.Settings.FlatAltitude, My.Settings.FlatAzimuth, SiteLat, SiteLong, 2)
        FinalRa = Astroformulas.RADec(Days2000, My.Settings.FlatAltitude, My.Settings.FlatAzimuth, SiteLat, SiteLong, 1)

        objtelescope.TargetRightAscension = FinalRa / 15
        objtelescope.TargetDeclination = FinalDec
        objtelescope.SlewToTargetAsync()
        BTNAbort.BackColor = Color.Yellow

        'Stop tracking facing Flat Panel
        objtelescope.Tracking = False

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
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        TenthSec = TenthSec + 1
        If TenthSec >= 450 Then
            Timer3.Stop() 'Timer stops functioning
            objtelescope.MoveAxis(1, 0)
        End If

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