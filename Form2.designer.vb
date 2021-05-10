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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTConfSelect = New System.Windows.Forms.Button()
        Me.BTRight = New System.Windows.Forms.Button()
        Me.BTLeft = New System.Windows.Forms.Button()
        Me.PBSetting = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBAngleSetting = New System.Windows.Forms.Label()
        Me.BTAutoSetTop = New System.Windows.Forms.Button()
        Me.LBAutoAngle = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTAutoSetBottom = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBAllowPast = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTSlewLeft = New System.Windows.Forms.Button()
        Me.BTSlewRight = New System.Windows.Forms.Button()
        CType(Me.PBSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTSaveexit
        '
        Me.BTSaveexit.BackColor = System.Drawing.Color.Lime
        Me.BTSaveexit.Location = New System.Drawing.Point(12, 295)
        Me.BTSaveexit.Name = "BTSaveexit"
        Me.BTSaveexit.Size = New System.Drawing.Size(125, 35)
        Me.BTSaveexit.TabIndex = 1
        Me.BTSaveexit.Text = "Save and Return"
        Me.BTSaveexit.UseVisualStyleBackColor = False
        '
        'BTConfCancel
        '
        Me.BTConfCancel.BackColor = System.Drawing.Color.Yellow
        Me.BTConfCancel.Location = New System.Drawing.Point(165, 295)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(372, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bulleye Position at NCP"
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
        'BTRight
        '
        Me.BTRight.BackgroundImage = Global.PolarAssist.My.Resources.Resources.Right_red_arrow
        Me.BTRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTRight.Location = New System.Drawing.Point(496, 269)
        Me.BTRight.Name = "BTRight"
        Me.BTRight.Size = New System.Drawing.Size(48, 48)
        Me.BTRight.TabIndex = 51
        Me.BTRight.UseVisualStyleBackColor = True
        '
        'BTLeft
        '
        Me.BTLeft.BackgroundImage = Global.PolarAssist.My.Resources.Resources.left_red_arrow
        Me.BTLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTLeft.Location = New System.Drawing.Point(304, 269)
        Me.BTLeft.Name = "BTLeft"
        Me.BTLeft.Size = New System.Drawing.Size(48, 48)
        Me.BTLeft.TabIndex = 50
        Me.BTLeft.UseVisualStyleBackColor = True
        '
        'PBSetting
        '
        Me.PBSetting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBSetting.BackColor = System.Drawing.Color.White
        Me.PBSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBSetting.Image = Global.PolarAssist.My.Resources.Resources.PolarScreen
        Me.PBSetting.Location = New System.Drawing.Point(304, 12)
        Me.PBSetting.Name = "PBSetting"
        Me.PBSetting.Size = New System.Drawing.Size(240, 240)
        Me.PBSetting.TabIndex = 49
        Me.PBSetting.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Shift Click fot bigger steps"
        '
        'LBAngleSetting
        '
        Me.LBAngleSetting.BackColor = System.Drawing.Color.IndianRed
        Me.LBAngleSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBAngleSetting.Location = New System.Drawing.Point(389, 287)
        Me.LBAngleSetting.Name = "LBAngleSetting"
        Me.LBAngleSetting.Size = New System.Drawing.Size(74, 30)
        Me.LBAngleSetting.TabIndex = 55
        Me.LBAngleSetting.Text = "0"
        Me.LBAngleSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTAutoSetTop
        '
        Me.BTAutoSetTop.BackColor = System.Drawing.Color.IndianRed
        Me.BTAutoSetTop.Enabled = False
        Me.BTAutoSetTop.Location = New System.Drawing.Point(43, 220)
        Me.BTAutoSetTop.Name = "BTAutoSetTop"
        Me.BTAutoSetTop.Size = New System.Drawing.Size(101, 23)
        Me.BTAutoSetTop.TabIndex = 56
        Me.BTAutoSetTop.Text = "Bullseye on TOP"
        Me.BTAutoSetTop.UseVisualStyleBackColor = False
        '
        'LBAutoAngle
        '
        Me.LBAutoAngle.BackColor = System.Drawing.Color.IndianRed
        Me.LBAutoAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBAutoAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBAutoAngle.Location = New System.Drawing.Point(164, 246)
        Me.LBAutoAngle.Name = "LBAutoAngle"
        Me.LBAutoAngle.Size = New System.Drawing.Size(74, 30)
        Me.LBAutoAngle.TabIndex = 57
        Me.LBAutoAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.IndianRed
        Me.TextBox1.Location = New System.Drawing.Point(42, 110)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 50)
        Me.TextBox1.TabIndex = 58
        Me.TextBox1.Text = "Connect and Quick Align Mount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Slew RA until BullEye is at" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " top or bottom and pr" &
    "ess Key"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(58, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 30)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Polaris Bulleye Angle"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(278, 2)
        Me.Label5.TabIndex = 60
        '
        'BTAutoSetBottom
        '
        Me.BTAutoSetBottom.BackColor = System.Drawing.Color.IndianRed
        Me.BTAutoSetBottom.Enabled = False
        Me.BTAutoSetBottom.Location = New System.Drawing.Point(149, 220)
        Me.BTAutoSetBottom.Name = "BTAutoSetBottom"
        Me.BTAutoSetBottom.Size = New System.Drawing.Size(118, 23)
        Me.BTAutoSetBottom.TabIndex = 61
        Me.BTAutoSetBottom.Text = "Bullseye on Bottom"
        Me.BTAutoSetBottom.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 2)
        Me.Label6.TabIndex = 62
        '
        'TBAllowPast
        '
        Me.TBAllowPast.Location = New System.Drawing.Point(206, 81)
        Me.TBAllowPast.Name = "TBAllowPast"
        Me.TBAllowPast.Size = New System.Drawing.Size(60, 20)
        Me.TBAllowPast.TabIndex = 63
        Me.TBAllowPast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Allow Slew past Meridian by :"
        '
        'BTSlewLeft
        '
        Me.BTSlewLeft.BackgroundImage = Global.PolarAssist.My.Resources.Resources.left_red_arrow
        Me.BTSlewLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTSlewLeft.Enabled = False
        Me.BTSlewLeft.Location = New System.Drawing.Point(96, 166)
        Me.BTSlewLeft.Name = "BTSlewLeft"
        Me.BTSlewLeft.Size = New System.Drawing.Size(48, 48)
        Me.BTSlewLeft.TabIndex = 66
        Me.BTSlewLeft.UseVisualStyleBackColor = True
        '
        'BTSlewRight
        '
        Me.BTSlewRight.BackgroundImage = Global.PolarAssist.My.Resources.Resources.Right_red_arrow
        Me.BTSlewRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTSlewRight.Enabled = False
        Me.BTSlewRight.Location = New System.Drawing.Point(150, 166)
        Me.BTSlewRight.Name = "BTSlewRight"
        Me.BTSlewRight.Size = New System.Drawing.Size(48, 48)
        Me.BTSlewRight.TabIndex = 65
        Me.BTSlewRight.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(625, 344)
        Me.Controls.Add(Me.BTSlewLeft)
        Me.Controls.Add(Me.BTSlewRight)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBAllowPast)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTAutoSetBottom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LBAutoAngle)
        Me.Controls.Add(Me.BTAutoSetTop)
        Me.Controls.Add(Me.LBAngleSetting)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTConfSelect)
        Me.Controls.Add(Me.BTRight)
        Me.Controls.Add(Me.BTLeft)
        Me.Controls.Add(Me.PBSetting)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBConfigScope)
        Me.Controls.Add(Me.BTConfCancel)
        Me.Controls.Add(Me.BTSaveexit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Configuration"
        CType(Me.PBSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTSaveexit As Button
    Friend WithEvents BTConfCancel As Button
    Friend WithEvents TBConfigScope As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PBSetting As PictureBox
    Friend WithEvents BTLeft As Button
    Friend WithEvents BTRight As Button
    Friend WithEvents BTConfSelect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LBAngleSetting As Label
    Friend WithEvents BTAutoSetTop As Button
    Friend WithEvents LBAutoAngle As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTAutoSetBottom As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TBAllowPast As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTSlewLeft As Button
    Friend WithEvents BTSlewRight As Button
End Class
