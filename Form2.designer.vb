<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BTSaveexit = New System.Windows.Forms.Button()
        Me.BTConfCancel = New System.Windows.Forms.Button()
        Me.TBConfigScope = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTConfSelect = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBAzimuth = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBAltitude = New System.Windows.Forms.TextBox()
        Me.BTGetAltAz = New System.Windows.Forms.Button()
        Me.BTSlewUp = New System.Windows.Forms.Button()
        Me.BTSlewDown = New System.Windows.Forms.Button()
        Me.BTSlewLeft = New System.Windows.Forms.Button()
        Me.BTSlewRight = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CurAz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurAlt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTSaveexit
        '
        Me.BTSaveexit.BackColor = System.Drawing.Color.Lime
        Me.BTSaveexit.Location = New System.Drawing.Point(181, 211)
        Me.BTSaveexit.Name = "BTSaveexit"
        Me.BTSaveexit.Size = New System.Drawing.Size(124, 35)
        Me.BTSaveexit.TabIndex = 1
        Me.BTSaveexit.Text = "Save and Return"
        Me.BTSaveexit.UseVisualStyleBackColor = False
        '
        'BTConfCancel
        '
        Me.BTConfCancel.BackColor = System.Drawing.Color.Yellow
        Me.BTConfCancel.Location = New System.Drawing.Point(13, 211)
        Me.BTConfCancel.Name = "BTConfCancel"
        Me.BTConfCancel.Size = New System.Drawing.Size(125, 35)
        Me.BTConfCancel.TabIndex = 2
        Me.BTConfCancel.Text = "Cancel"
        Me.BTConfCancel.UseVisualStyleBackColor = False
        '
        'TBConfigScope
        '
        Me.TBConfigScope.Location = New System.Drawing.Point(41, 51)
        Me.TBConfigScope.Name = "TBConfigScope"
        Me.TBConfigScope.Size = New System.Drawing.Size(225, 20)
        Me.TBConfigScope.TabIndex = 3
        Me.TBConfigScope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Default Scope"
        '
        'BTConfSelect
        '
        Me.BTConfSelect.Location = New System.Drawing.Point(191, 18)
        Me.BTConfSelect.Name = "BTConfSelect"
        Me.BTConfSelect.Size = New System.Drawing.Size(75, 23)
        Me.BTConfSelect.TabIndex = 52
        Me.BTConfSelect.Text = "Select"
        Me.BTConfSelect.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.IndianRed
        Me.TextBox1.Location = New System.Drawing.Point(13, 120)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 40)
        Me.TextBox1.TabIndex = 58
        Me.TextBox1.Text = "Flat Panel location setting"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 2)
        Me.Label5.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 5)
        Me.Label6.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Azimuth"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBAzimuth
        '
        Me.TBAzimuth.Location = New System.Drawing.Point(181, 144)
        Me.TBAzimuth.Name = "TBAzimuth"
        Me.TBAzimuth.Size = New System.Drawing.Size(124, 20)
        Me.TBAzimuth.TabIndex = 65
        Me.TBAzimuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Altitude"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TBAltitude
        '
        Me.TBAltitude.Location = New System.Drawing.Point(181, 118)
        Me.TBAltitude.Name = "TBAltitude"
        Me.TBAltitude.Size = New System.Drawing.Size(124, 20)
        Me.TBAltitude.TabIndex = 63
        Me.TBAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTGetAltAz
        '
        Me.BTGetAltAz.BackColor = System.Drawing.Color.Red
        Me.BTGetAltAz.Enabled = False
        Me.BTGetAltAz.Location = New System.Drawing.Point(181, 170)
        Me.BTGetAltAz.Name = "BTGetAltAz"
        Me.BTGetAltAz.Size = New System.Drawing.Size(125, 25)
        Me.BTGetAltAz.TabIndex = 67
        Me.BTGetAltAz.Text = "Get Current Alt and Az"
        Me.BTGetAltAz.UseVisualStyleBackColor = False
        '
        'BTSlewUp
        '
        Me.BTSlewUp.BackgroundImage = CType(resources.GetObject("BTSlewUp.BackgroundImage"), System.Drawing.Image)
        Me.BTSlewUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTSlewUp.Enabled = False
        Me.BTSlewUp.Location = New System.Drawing.Point(65, 332)
        Me.BTSlewUp.Name = "BTSlewUp"
        Me.BTSlewUp.Size = New System.Drawing.Size(48, 48)
        Me.BTSlewUp.TabIndex = 71
        Me.BTSlewUp.UseVisualStyleBackColor = True
        '
        'BTSlewDown
        '
        Me.BTSlewDown.BackgroundImage = CType(resources.GetObject("BTSlewDown.BackgroundImage"), System.Drawing.Image)
        Me.BTSlewDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTSlewDown.Enabled = False
        Me.BTSlewDown.Location = New System.Drawing.Point(65, 386)
        Me.BTSlewDown.Name = "BTSlewDown"
        Me.BTSlewDown.Size = New System.Drawing.Size(48, 48)
        Me.BTSlewDown.TabIndex = 70
        Me.BTSlewDown.UseVisualStyleBackColor = True
        '
        'BTSlewLeft
        '
        Me.BTSlewLeft.BackgroundImage = Global.FlatPanelAssist.My.Resources.Resources.left_red_arrow
        Me.BTSlewLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTSlewLeft.Enabled = False
        Me.BTSlewLeft.Location = New System.Drawing.Point(20, 357)
        Me.BTSlewLeft.Name = "BTSlewLeft"
        Me.BTSlewLeft.Size = New System.Drawing.Size(48, 48)
        Me.BTSlewLeft.TabIndex = 69
        Me.BTSlewLeft.UseVisualStyleBackColor = True
        '
        'BTSlewRight
        '
        Me.BTSlewRight.BackgroundImage = Global.FlatPanelAssist.My.Resources.Resources.Right_red_arrow
        Me.BTSlewRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTSlewRight.Enabled = False
        Me.BTSlewRight.Location = New System.Drawing.Point(111, 357)
        Me.BTSlewRight.Name = "BTSlewRight"
        Me.BTSlewRight.Size = New System.Drawing.Size(48, 48)
        Me.BTSlewRight.TabIndex = 68
        Me.BTSlewRight.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Az."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CurAz
        '
        Me.CurAz.Location = New System.Drawing.Point(198, 386)
        Me.CurAz.Name = "CurAz"
        Me.CurAz.Size = New System.Drawing.Size(99, 20)
        Me.CurAz.TabIndex = 74
        Me.CurAz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Alt."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CurAlt
        '
        Me.CurAlt.Location = New System.Drawing.Point(198, 360)
        Me.CurAlt.Name = "CurAlt"
        Me.CurAlt.Size = New System.Drawing.Size(99, 20)
        Me.CurAlt.TabIndex = 72
        Me.CurAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(220, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Current"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(317, 444)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CurAz)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CurAlt)
        Me.Controls.Add(Me.BTSlewUp)
        Me.Controls.Add(Me.BTSlewDown)
        Me.Controls.Add(Me.BTSlewLeft)
        Me.Controls.Add(Me.BTSlewRight)
        Me.Controls.Add(Me.BTGetAltAz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBAzimuth)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBAltitude)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTConfSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBConfigScope)
        Me.Controls.Add(Me.BTConfCancel)
        Me.Controls.Add(Me.BTSaveexit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTSaveexit As Button
    Friend WithEvents BTConfCancel As Button
    Friend WithEvents TBConfigScope As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTConfSelect As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBAzimuth As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBAltitude As TextBox
    Friend WithEvents BTGetAltAz As Button
    Friend WithEvents BTSlewLeft As Button
    Friend WithEvents BTSlewRight As Button
    Friend WithEvents BTSlewUp As Button
    Friend WithEvents BTSlewDown As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CurAz As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CurAlt As TextBox
    Friend WithEvents Label8 As Label
End Class
