Public Class Form2

    Dim FlatAltitude As Double = My.Settings.FlatAltitude
    Dim FlatAzimuth As Double = My.Settings.FlatAzimuth
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBConfigScope.Text = My.Settings.Telescope

        TBAltitude.Text = Form1.DDtohms(FlatAltitude, 2)
        TBAzimuth.Text = Form1.DDtohms(FlatAzimuth, 2)


        If Form1.Timer1.Enabled = True Then
            BTGetAltAz.Enabled = True
            BTGetAltAz.BackColor = Color.LimeGreen
        End If
    End Sub

    Private Sub BTSlewLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles BTSlewLeft.MouseDown
        Form1.objtelescope.MoveAxis(0, -4)
    End Sub

    Private Sub BTSlewLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles BTSlewLeft.MouseUp
        Form1.objtelescope.MoveAxis(0, 0)
    End Sub
    Private Sub BTSlewRight_MouseDown(sender As Object, e As MouseEventArgs) Handles BTSlewRight.MouseDown
        Form1.objtelescope.MoveAxis(0, 4)
    End Sub
    Private Sub BTSlewRight_MouseUp(sender As Object, e As MouseEventArgs) Handles BTSlewRight.MouseUp
        Form1.objtelescope.MoveAxis(0, 0)
    End Sub
    Private Sub BTSlewUp_MouseDown(sender As Object, e As MouseEventArgs) Handles BTSlewUp.MouseDown
        Form1.objtelescope.MoveAxis(1, -4)
    End Sub
    Private Sub BTSlewUp_MouseUp(sender As Object, e As MouseEventArgs) Handles BTSlewUp.MouseUp
        Form1.objtelescope.MoveAxis(1, 0)
    End Sub
    Private Sub BTSlewDown_MouseDown(sender As Object, e As MouseEventArgs) Handles BTSlewDown.MouseDown
        Form1.objtelescope.MoveAxis(1, 4)
    End Sub
    Private Sub BTSlewDown_MouseUp(sender As Object, e As MouseEventArgs) Handles BTSlewDown.MouseUp
        Form1.objtelescope.MoveAxis(1, 0)
    End Sub



    Private Sub BTSaveexit_Click(sender As Object, e As EventArgs) Handles BTSaveexit.Click
        My.Settings.FlatAltitude = FlatAltitude
        My.Settings.FlatAzimuth = FlatAzimuth

        'Form1.TarFlatAltitude = FlatAltitude
        ' Form1.TarFlatAzimuth = FlatAzimuth
        My.Settings.Save()

        ' If Scope is not connected
        If Form1.Timer1.Enabled = False Then
            Form1.Form1_Show(2, e) 'I have no idea how to pass arguments and it seems unused
            Form1.ReadytoConnect()
        End If
        Form1.TBTelescope.Text = My.Settings.Telescope
        Form1.TBTargetAltitude.Text = Form1.DDtohms(FlatAltitude, 2)
        Form1.TBTargetAzimuth.Text = Form1.DDtohms(FlatAzimuth, 2)

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

    Private Sub BTGetAltAz_Click(sender As Object, e As EventArgs) Handles BTGetAltAz.Click
        FlatAltitude = Form1.MountAltitude
        FlatAzimuth = Form1.MountAzimuth
        TBAltitude.Text = Form1.DDtohms(FlatAltitude, 2)
        TBAzimuth.Text = Form1.DDtohms(FlatAzimuth, 2)

    End Sub


End Class