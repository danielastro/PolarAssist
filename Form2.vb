Public Class Form2

    Dim OriginalImage = My.Resources.PolarScreen
    Dim ConfigAngle = My.Settings.AngleSetting
    Dim AllowPastAngle As Double = My.Settings.PastHorizon
    Dim Bmp As Bitmap
    Dim MountSideofPier As ASCOM.DeviceInterface.PierSide

    Dim AutoTargetPos As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Rotate image to match PScope as per setting
        LBAngleSetting.Text = Convert.ToString(ConfigAngle)

        Bmp = Form1.RotateImage(OriginalImage, +ConfigAngle)
        PBSetting.Image = Bmp
        TBConfigScope.Text = My.Settings.Telescope
        If Form1.Timer1.Enabled = True Then
            BTAutoSetTop.Enabled = True
        End If
        TBAllowPast.Text = AllowPastAngle
    End Sub

    Private Sub BTLeft_Click(sender As Object, e As EventArgs) Handles BTLeft.Click
        'Rotating the image clockwise

        If ModifierKeys.HasFlag(Keys.Shift) Then 'shift click moves it faster
            ConfigAngle = ConfigAngle + 10
        Else
            ConfigAngle = ConfigAngle + 1
        End If

        If ConfigAngle < 0 Then
            ConfigAngle += 360
        End If
        If ConfigAngle > 359 Then
            ConfigAngle -= 360
        End If

        LBAngleSetting.Text = Form1.DDtohms(ConfigAngle, 3)
        Bmp = Form1.RotateImage(OriginalImage, +ConfigAngle)
        PBSetting.Image = Bmp

    End Sub

    Private Sub BTRight_Click(sender As Object, e As EventArgs) Handles BTRight.Click
        'Rotating the image CounterClockwise

        If ModifierKeys.HasFlag(Keys.Shift) Then 'shift click moves it faster
            ConfigAngle = ConfigAngle - 10
        Else
            ConfigAngle = ConfigAngle - 1
        End If

        If ConfigAngle < 0 Then
            ConfigAngle = ConfigAngle + 360
        End If
        If ConfigAngle > 359 Then
            ConfigAngle = ConfigAngle - 360
        End If

        LBAngleSetting.Text = Form1.DDtohms(ConfigAngle, 3)
        Bmp = Form1.RotateImage(OriginalImage, +ConfigAngle)
        PBSetting.Image = Bmp
    End Sub

    Private Sub BTSaveexit_Click(sender As Object, e As EventArgs) Handles BTSaveexit.Click
        My.Settings.AngleSetting = ConfigAngle
        Form1.SettingAngle = ConfigAngle
        My.Settings.PastHorizon = AllowPastAngle
        My.Settings.Save()

        ' If Scope is not connected
        If Form1.Timer1.Enabled = False Then
            Form1.CurrentBullseyePos = ConfigAngle
            Form1.Form1_Show(2, e) 'I have no idea how to pass arguments and it seems unused
            Form1.ReadytoConnect()
        End If
        Form1.TBTelescope.Text = My.Settings.Telescope

        Form1.Activate()
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub BTConfCancel_Click(sender As Object, e As EventArgs) Handles BTConfCancel.Click
        Me.Close()
    End Sub
    Private Sub BTConfSelect_Click(sender As Object, e As EventArgs) Handles BTConfSelect.Click
        'Ascom Sub to chose the Ascom Scope for Config
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "Telescope"

        'Text Box TBConfigScope displays the chosen scope
        Try
            My.Settings.Telescope = obj.Choose(My.Settings.Telescope)
            TBConfigScope.Text = My.Settings.Telescope
        Catch ex As System.NullReferenceException
            MessageBox.Show("Problem Connecting, Check selection")
        End Try
    End Sub

    Private Sub BTAutoSetTop_Click(sender As Object, e As EventArgs) Handles BTAutoSetTop.Click
        MountSideofPier = Form1.objtelescope.SideOfPier
        Dim AutoTargetPos As Double
        If MountSideofPier = 0 Then
            AutoTargetPos = Form1.Range360(360 - ((Form1.objtelescope.RightAscension * 15) - (Form1.LSidereal) - 90) + 180)
        Else
            AutoTargetPos = Form1.Range360(360 - ((Form1.objtelescope.RightAscension * 15) - (Form1.LSidereal) + 90) + 180)
        End If

        AutoTargetPos = Math.Floor(AutoTargetPos)

        ConfigAngle = AutoTargetPos

        LBAutoAngle.Text = Form1.DDtohms(AutoTargetPos, 3)
        LBAngleSetting.Text = Form1.DDtohms(ConfigAngle, 3)
        Bmp = Form1.RotateImage(OriginalImage, +ConfigAngle)
        PBSetting.Image = Bmp
    End Sub

    Private Sub BTAutoSetBottom_Click(sender As Object, e As EventArgs) Handles BTAutoSetBottom.Click
        MountSideofPier = Form1.objtelescope.SideOfPier
        Dim AutoTargetPos As Double
        If MountSideofPier = 0 Then
            AutoTargetPos = Form1.Range360(360 - ((Form1.objtelescope.RightAscension * 15) - (Form1.LSidereal) - 90))
        Else
            AutoTargetPos = Form1.Range360(360 - ((Form1.objtelescope.RightAscension * 15) - (Form1.LSidereal) + 90))
        End If

        AutoTargetPos = Math.Floor(AutoTargetPos)

        ConfigAngle = AutoTargetPos

        LBAutoAngle.Text = Form1.DDtohms(AutoTargetPos, 3)
        LBAngleSetting.Text = Form1.DDtohms(ConfigAngle, 3)
        Bmp = Form1.RotateImage(OriginalImage, +ConfigAngle)
        PBSetting.Image = Bmp

    End Sub

    Private Sub TBAllowPast_TextChanged(sender As Object, e As EventArgs) Handles TBAllowPast.TextChanged
        AllowPastAngle = TBAllowPast.Text

    End Sub


End Class