<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TBLocalTime = New System.Windows.Forms.TextBox()
        Me.LBLLocaltime = New System.Windows.Forms.Label()
        Me.LBLutc = New System.Windows.Forms.Label()
        Me.TBUtc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBJ2000 = New System.Windows.Forms.TextBox()
        Me.LBLMsiderealTime = New System.Windows.Forms.Label()
        Me.TBMSidereal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTargetAltitude = New System.Windows.Forms.TextBox()
        Me.BTNSlew = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBLSidereal = New System.Windows.Forms.TextBox()
        Me.BTNAbort = New System.Windows.Forms.Button()
        Me.CBTracking = New System.Windows.Forms.CheckBox()
        Me.CBSlewing = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTConfigure = New System.Windows.Forms.Button()
        Me.TBTargetAzimuth = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.BTNSelect = New System.Windows.Forms.Button()
        Me.TBTelescope = New System.Windows.Forms.TextBox()
        Me.BTNConnect = New System.Windows.Forms.Button()
        Me.TBScopeLat = New System.Windows.Forms.TextBox()
        Me.LBLLatitude = New System.Windows.Forms.Label()
        Me.TBScopeLong = New System.Windows.Forms.TextBox()
        Me.LBLLongitude = New System.Windows.Forms.Label()
        Me.TBRa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBDec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBAltitude = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBAzimuth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNDisconnect = New System.Windows.Forms.Button()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.TBSideofpier = New System.Windows.Forms.TextBox()
        Me.TBMountAngle = New System.Windows.Forms.TextBox()
        Me.Vline1 = New System.Windows.Forms.TextBox()
        Me.Vline2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TBMountSidereal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBLocalTime
        '
        Me.TBLocalTime.Location = New System.Drawing.Point(123, 54)
        Me.TBLocalTime.Name = "TBLocalTime"
        Me.TBLocalTime.Size = New System.Drawing.Size(115, 20)
        Me.TBLocalTime.TabIndex = 4
        Me.TBLocalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLLocaltime
        '
        Me.LBLLocaltime.AutoSize = True
        Me.LBLLocaltime.Location = New System.Drawing.Point(55, 57)
        Me.LBLLocaltime.Name = "LBLLocaltime"
        Me.LBLLocaltime.Size = New System.Drawing.Size(62, 13)
        Me.LBLLocaltime.TabIndex = 5
        Me.LBLLocaltime.Text = "Local Time:"
        Me.LBLLocaltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLutc
        '
        Me.LBLutc.AutoSize = True
        Me.LBLutc.Location = New System.Drawing.Point(81, 83)
        Me.LBLutc.Name = "LBLutc"
        Me.LBLutc.Size = New System.Drawing.Size(29, 13)
        Me.LBLutc.TabIndex = 8
        Me.LBLutc.Text = "UTC"
        Me.LBLutc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBUtc
        '
        Me.TBUtc.Location = New System.Drawing.Point(123, 80)
        Me.TBUtc.Name = "TBUtc"
        Me.TBUtc.Size = New System.Drawing.Size(115, 20)
        Me.TBUtc.TabIndex = 7
        Me.TBUtc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Days since J2000"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBJ2000
        '
        Me.TBJ2000.Location = New System.Drawing.Point(123, 118)
        Me.TBJ2000.Name = "TBJ2000"
        Me.TBJ2000.Size = New System.Drawing.Size(115, 20)
        Me.TBJ2000.TabIndex = 9
        Me.TBJ2000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLMsiderealTime
        '
        Me.LBLMsiderealTime.AutoSize = True
        Me.LBLMsiderealTime.Location = New System.Drawing.Point(16, 147)
        Me.LBLMsiderealTime.Name = "LBLMsiderealTime"
        Me.LBLMsiderealTime.Size = New System.Drawing.Size(101, 13)
        Me.LBLMsiderealTime.TabIndex = 12
        Me.LBLMsiderealTime.Text = "Mean Sidereal Time"
        Me.LBLMsiderealTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBMSidereal
        '
        Me.TBMSidereal.Location = New System.Drawing.Point(123, 144)
        Me.TBMSidereal.Name = "TBMSidereal"
        Me.TBMSidereal.Size = New System.Drawing.Size(115, 20)
        Me.TBMSidereal.TabIndex = 11
        Me.TBMSidereal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Targeted Altitude"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBTargetAltitude
        '
        Me.TBTargetAltitude.Location = New System.Drawing.Point(371, 51)
        Me.TBTargetAltitude.Name = "TBTargetAltitude"
        Me.TBTargetAltitude.Size = New System.Drawing.Size(75, 20)
        Me.TBTargetAltitude.TabIndex = 30
        Me.TBTargetAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNSlew
        '
        Me.BTNSlew.BackColor = System.Drawing.Color.Red
        Me.BTNSlew.Enabled = False
        Me.BTNSlew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSlew.Location = New System.Drawing.Point(305, 112)
        Me.BTNSlew.Name = "BTNSlew"
        Me.BTNSlew.Size = New System.Drawing.Size(141, 48)
        Me.BTNSlew.TabIndex = 36
        Me.BTNSlew.Text = "Slew to Flat Panel"
        Me.BTNSlew.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Local Sidereal Time"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBLSidereal
        '
        Me.TBLSidereal.Location = New System.Drawing.Point(123, 170)
        Me.TBLSidereal.Name = "TBLSidereal"
        Me.TBLSidereal.Size = New System.Drawing.Size(115, 20)
        Me.TBLSidereal.TabIndex = 37
        Me.TBLSidereal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNAbort
        '
        Me.BTNAbort.BackColor = System.Drawing.Color.Silver
        Me.BTNAbort.Enabled = False
        Me.BTNAbort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAbort.Location = New System.Drawing.Point(371, 170)
        Me.BTNAbort.Name = "BTNAbort"
        Me.BTNAbort.Size = New System.Drawing.Size(75, 43)
        Me.BTNAbort.TabIndex = 42
        Me.BTNAbort.Text = "Abort"
        Me.BTNAbort.UseVisualStyleBackColor = False
        '
        'CBTracking
        '
        Me.CBTracking.Location = New System.Drawing.Point(329, 225)
        Me.CBTracking.Name = "CBTracking"
        Me.CBTracking.Size = New System.Drawing.Size(115, 24)
        Me.CBTracking.TabIndex = 46
        Me.CBTracking.Text = "Tracking"
        Me.CBTracking.UseVisualStyleBackColor = True
        '
        'CBSlewing
        '
        Me.CBSlewing.Location = New System.Drawing.Point(329, 250)
        Me.CBSlewing.Name = "CBSlewing"
        Me.CBSlewing.Size = New System.Drawing.Size(115, 24)
        Me.CBSlewing.TabIndex = 47
        Me.CBSlewing.Text = "Slewing"
        Me.CBSlewing.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BTConfigure
        '
        Me.BTConfigure.BackColor = System.Drawing.Color.LimeGreen
        Me.BTConfigure.Location = New System.Drawing.Point(58, 360)
        Me.BTConfigure.Name = "BTConfigure"
        Me.BTConfigure.Size = New System.Drawing.Size(115, 34)
        Me.BTConfigure.TabIndex = 49
        Me.BTConfigure.Text = "Configure"
        Me.BTConfigure.UseVisualStyleBackColor = False
        '
        'TBTargetAzimuth
        '
        Me.TBTargetAzimuth.Location = New System.Drawing.Point(371, 77)
        Me.TBTargetAzimuth.Name = "TBTargetAzimuth"
        Me.TBTargetAzimuth.Size = New System.Drawing.Size(75, 20)
        Me.TBTargetAzimuth.TabIndex = 50
        Me.TBTargetAzimuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(528, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Side of Pier"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(272, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Targeted Azimuth"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(530, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "DEC Angle"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        '
        'BTNSelect
        '
        Me.BTNSelect.BackColor = System.Drawing.Color.LimeGreen
        Me.BTNSelect.Location = New System.Drawing.Point(598, 16)
        Me.BTNSelect.Name = "BTNSelect"
        Me.BTNSelect.Size = New System.Drawing.Size(115, 33)
        Me.BTNSelect.TabIndex = 0
        Me.BTNSelect.Text = "Select Scope"
        Me.BTNSelect.UseVisualStyleBackColor = False
        '
        'TBTelescope
        '
        Me.TBTelescope.Location = New System.Drawing.Point(574, 55)
        Me.TBTelescope.Name = "TBTelescope"
        Me.TBTelescope.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TBTelescope.Size = New System.Drawing.Size(166, 20)
        Me.TBTelescope.TabIndex = 18
        '
        'BTNConnect
        '
        Me.BTNConnect.BackColor = System.Drawing.Color.Red
        Me.BTNConnect.Enabled = False
        Me.BTNConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTNConnect.Location = New System.Drawing.Point(598, 81)
        Me.BTNConnect.Name = "BTNConnect"
        Me.BTNConnect.Size = New System.Drawing.Size(115, 32)
        Me.BTNConnect.TabIndex = 3
        Me.BTNConnect.Text = "Connect"
        Me.BTNConnect.UseVisualStyleBackColor = False
        '
        'TBScopeLat
        '
        Me.TBScopeLat.Location = New System.Drawing.Point(598, 209)
        Me.TBScopeLat.Name = "TBScopeLat"
        Me.TBScopeLat.Size = New System.Drawing.Size(115, 20)
        Me.TBScopeLat.TabIndex = 13
        Me.TBScopeLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLLatitude
        '
        Me.LBLLatitude.AutoSize = True
        Me.LBLLatitude.Location = New System.Drawing.Point(539, 216)
        Me.LBLLatitude.Name = "LBLLatitude"
        Me.LBLLatitude.Size = New System.Drawing.Size(45, 13)
        Me.LBLLatitude.TabIndex = 14
        Me.LBLLatitude.Text = "Latitude"
        Me.LBLLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBScopeLong
        '
        Me.TBScopeLong.Location = New System.Drawing.Point(598, 235)
        Me.TBScopeLong.Name = "TBScopeLong"
        Me.TBScopeLong.Size = New System.Drawing.Size(115, 20)
        Me.TBScopeLong.TabIndex = 15
        Me.TBScopeLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLLongitude
        '
        Me.LBLLongitude.AutoSize = True
        Me.LBLLongitude.Location = New System.Drawing.Point(538, 242)
        Me.LBLLongitude.Name = "LBLLongitude"
        Me.LBLLongitude.Size = New System.Drawing.Size(54, 13)
        Me.LBLLongitude.TabIndex = 16
        Me.LBLLongitude.Text = "Longitude"
        Me.LBLLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBRa
        '
        Me.TBRa.Location = New System.Drawing.Point(598, 272)
        Me.TBRa.Name = "TBRa"
        Me.TBRa.Size = New System.Drawing.Size(115, 20)
        Me.TBRa.TabIndex = 20
        Me.TBRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(556, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "R.A."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBDec
        '
        Me.TBDec.Location = New System.Drawing.Point(598, 298)
        Me.TBDec.Name = "TBDec"
        Me.TBDec.Size = New System.Drawing.Size(115, 20)
        Me.TBDec.TabIndex = 22
        Me.TBDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "DEC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBAltitude
        '
        Me.TBAltitude.Location = New System.Drawing.Point(598, 328)
        Me.TBAltitude.Name = "TBAltitude"
        Me.TBAltitude.Size = New System.Drawing.Size(115, 20)
        Me.TBAltitude.TabIndex = 24
        Me.TBAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(548, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Altitude"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBAzimuth
        '
        Me.TBAzimuth.Location = New System.Drawing.Point(598, 354)
        Me.TBAzimuth.Name = "TBAzimuth"
        Me.TBAzimuth.Size = New System.Drawing.Size(115, 20)
        Me.TBAzimuth.TabIndex = 26
        Me.TBAzimuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(548, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Azimuth"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNDisconnect
        '
        Me.BTNDisconnect.BackColor = System.Drawing.Color.Red
        Me.BTNDisconnect.Enabled = False
        Me.BTNDisconnect.Location = New System.Drawing.Point(598, 119)
        Me.BTNDisconnect.Name = "BTNDisconnect"
        Me.BTNDisconnect.Size = New System.Drawing.Size(115, 32)
        Me.BTNDisconnect.TabIndex = 43
        Me.BTNDisconnect.Text = "Disconnect"
        Me.BTNDisconnect.UseVisualStyleBackColor = False
        '
        'BTNExit
        '
        Me.BTNExit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BTNExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNExit.Location = New System.Drawing.Point(617, 157)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(75, 46)
        Me.BTNExit.TabIndex = 44
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = False
        '
        'TBSideofpier
        '
        Me.TBSideofpier.Location = New System.Drawing.Point(598, 408)
        Me.TBSideofpier.Name = "TBSideofpier"
        Me.TBSideofpier.Size = New System.Drawing.Size(115, 20)
        Me.TBSideofpier.TabIndex = 51
        Me.TBSideofpier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBMountAngle
        '
        Me.TBMountAngle.Location = New System.Drawing.Point(598, 382)
        Me.TBMountAngle.Name = "TBMountAngle"
        Me.TBMountAngle.Size = New System.Drawing.Size(115, 20)
        Me.TBMountAngle.TabIndex = 62
        Me.TBMountAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vline1
        '
        Me.Vline1.BackColor = System.Drawing.Color.Black
        Me.Vline1.Location = New System.Drawing.Point(506, 8)
        Me.Vline1.Multiline = True
        Me.Vline1.Name = "Vline1"
        Me.Vline1.Size = New System.Drawing.Size(10, 425)
        Me.Vline1.TabIndex = 64
        '
        'Vline2
        '
        Me.Vline2.BackColor = System.Drawing.Color.Black
        Me.Vline2.Location = New System.Drawing.Point(244, 8)
        Me.Vline2.Multiline = True
        Me.Vline2.Name = "Vline2"
        Me.Vline2.Size = New System.Drawing.Size(10, 425)
        Me.Vline2.TabIndex = 65
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(39, 334)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 10)
        Me.TextBox1.TabIndex = 66
        '
        'TBMountSidereal
        '
        Me.TBMountSidereal.Location = New System.Drawing.Point(123, 196)
        Me.TBMountSidereal.Name = "TBMountSidereal"
        Me.TBMountSidereal.Size = New System.Drawing.Size(115, 20)
        Me.TBMountSidereal.TabIndex = 67
        Me.TBMountSidereal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Mount LST"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBMountSidereal)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Vline2)
        Me.Controls.Add(Me.Vline1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBMountAngle)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBSideofpier)
        Me.Controls.Add(Me.TBTargetAzimuth)
        Me.Controls.Add(Me.BTConfigure)
        Me.Controls.Add(Me.CBSlewing)
        Me.Controls.Add(Me.CBTracking)
        Me.Controls.Add(Me.BTNExit)
        Me.Controls.Add(Me.BTNDisconnect)
        Me.Controls.Add(Me.BTNAbort)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBLSidereal)
        Me.Controls.Add(Me.BTNSlew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBTargetAltitude)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBAzimuth)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBAltitude)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBDec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBRa)
        Me.Controls.Add(Me.LBLLongitude)
        Me.Controls.Add(Me.TBScopeLong)
        Me.Controls.Add(Me.LBLLatitude)
        Me.Controls.Add(Me.TBScopeLat)
        Me.Controls.Add(Me.LBLMsiderealTime)
        Me.Controls.Add(Me.TBMSidereal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBJ2000)
        Me.Controls.Add(Me.LBLutc)
        Me.Controls.Add(Me.TBUtc)
        Me.Controls.Add(Me.LBLLocaltime)
        Me.Controls.Add(Me.TBLocalTime)
        Me.Controls.Add(Me.BTNConnect)
        Me.Controls.Add(Me.TBTelescope)
        Me.Controls.Add(Me.BTNSelect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Flat Panel Assist1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBLocalTime As TextBox
    Friend WithEvents LBLLocaltime As Label
    Friend WithEvents LBLutc As Label
    Friend WithEvents TBUtc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBJ2000 As TextBox
    Friend WithEvents LBLMsiderealTime As Label
    Friend WithEvents TBMSidereal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTargetAltitude As TextBox
    Friend WithEvents BTNSlew As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TBLSidereal As TextBox
    Friend WithEvents BTNAbort As Button
    Friend WithEvents CBTracking As CheckBox
    Friend WithEvents CBSlewing As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BTConfigure As Button
    Friend WithEvents TBTargetAzimuth As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents BTNSelect As Button
    Friend WithEvents TBTelescope As TextBox
    Friend WithEvents BTNConnect As Button
    Friend WithEvents TBScopeLat As TextBox
    Friend WithEvents LBLLatitude As Label
    Friend WithEvents TBScopeLong As TextBox
    Friend WithEvents LBLLongitude As Label
    Friend WithEvents TBRa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBDec As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBAltitude As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBAzimuth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNDisconnect As Button
    Friend WithEvents BTNExit As Button
    Friend WithEvents TBSideofpier As TextBox
    Friend WithEvents TBMountAngle As TextBox
    Friend WithEvents Vline1 As TextBox
    Friend WithEvents Vline2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TBMountSidereal As TextBox
    Friend WithEvents Label11 As Label
End Class
