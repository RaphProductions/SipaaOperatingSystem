<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SPanel1 = New Sipaa.Framework.SPanel()
        Me.SPanel3 = New Sipaa.Framework.SPanel()
        Me.SButton4 = New Sipaa.Framework.SButton()
        Me.SButton1 = New Sipaa.Framework.SButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SPanel2 = New Sipaa.Framework.SPanel()
        Me.SButton9 = New Sipaa.Framework.SButton()
        Me.SButton8 = New Sipaa.Framework.SButton()
        Me.SButton7 = New Sipaa.Framework.SButton()
        Me.SButton6 = New Sipaa.Framework.SButton()
        Me.SButton5 = New Sipaa.Framework.SButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SButton3 = New Sipaa.Framework.SButton()
        Me.SButton2 = New Sipaa.Framework.SButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SystemTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SPanel1.SuspendLayout()
        Me.SPanel3.SuspendLayout()
        Me.SPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SPanel1
        '
        Me.SPanel1.BackColor = System.Drawing.Color.White
        Me.SPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.SPanel1.BorderRadius = 0
        Me.SPanel1.BorderSize = 0
        Me.SPanel1.Controls.Add(Me.SPanel3)
        Me.SPanel1.Controls.Add(Me.Label3)
        Me.SPanel1.Controls.Add(Me.Label2)
        Me.SPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SPanel1.ForeColor = System.Drawing.Color.White
        Me.SPanel1.Location = New System.Drawing.Point(0, 662)
        Me.SPanel1.Name = "SPanel1"
        Me.SPanel1.Size = New System.Drawing.Size(1228, 40)
        Me.SPanel1.TabIndex = 0
        '
        'SPanel3
        '
        Me.SPanel3.BackColor = System.Drawing.Color.Transparent
        Me.SPanel3.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel3.BorderRadius = 0
        Me.SPanel3.BorderSize = 0
        Me.SPanel3.Controls.Add(Me.SButton4)
        Me.SPanel3.Controls.Add(Me.SButton1)
        Me.SPanel3.ForeColor = System.Drawing.Color.White
        Me.SPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SPanel3.Name = "SPanel3"
        Me.SPanel3.Size = New System.Drawing.Size(83, 40)
        Me.SPanel3.TabIndex = 3
        '
        'SButton4
        '
        Me.SButton4.BackColor = System.Drawing.Color.Transparent
        Me.SButton4.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton4.BorderRadius = 6
        Me.SButton4.BorderSize = 0
        Me.SButton4.FlatAppearance.BorderSize = 0
        Me.SButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.SButton4.ForeColor = System.Drawing.Color.Black
        Me.SButton4.Image = Global.SipaaOS.My.Resources.Resources.explorer32
        Me.SButton4.Location = New System.Drawing.Point(43, 3)
        Me.SButton4.Name = "SButton4"
        Me.SButton4.Size = New System.Drawing.Size(34, 34)
        Me.SButton4.TabIndex = 1
        Me.SButton4.UseVisualStyleBackColor = False
        '
        'SButton1
        '
        Me.SButton1.BackColor = System.Drawing.Color.Transparent
        Me.SButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton1.BorderRadius = 6
        Me.SButton1.BorderSize = 0
        Me.SButton1.FlatAppearance.BorderSize = 0
        Me.SButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.SButton1.ForeColor = System.Drawing.Color.Black
        Me.SButton1.Location = New System.Drawing.Point(3, 3)
        Me.SButton1.Name = "SButton1"
        Me.SButton1.Size = New System.Drawing.Size(34, 34)
        Me.SButton1.TabIndex = 0
        Me.SButton1.Text = "S"
        Me.SButton1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1162, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "12/12/2021"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1191, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "12:30"
        '
        'SPanel2
        '
        Me.SPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SPanel2.BackColor = System.Drawing.Color.White
        Me.SPanel2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel2.BorderRadius = 6
        Me.SPanel2.BorderSize = 0
        Me.SPanel2.Controls.Add(Me.SButton9)
        Me.SPanel2.Controls.Add(Me.SButton8)
        Me.SPanel2.Controls.Add(Me.SButton7)
        Me.SPanel2.Controls.Add(Me.SButton6)
        Me.SPanel2.Controls.Add(Me.SButton5)
        Me.SPanel2.Controls.Add(Me.Label4)
        Me.SPanel2.Controls.Add(Me.SButton3)
        Me.SPanel2.Controls.Add(Me.SButton2)
        Me.SPanel2.Controls.Add(Me.Label1)
        Me.SPanel2.Controls.Add(Me.TextBox1)
        Me.SPanel2.ForeColor = System.Drawing.Color.Black
        Me.SPanel2.Location = New System.Drawing.Point(3, 208)
        Me.SPanel2.Name = "SPanel2"
        Me.SPanel2.Size = New System.Drawing.Size(406, 451)
        Me.SPanel2.TabIndex = 1
        Me.SPanel2.Visible = False
        '
        'SButton9
        '
        Me.SButton9.BackColor = System.Drawing.Color.Transparent
        Me.SButton9.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton9.BorderRadius = 6
        Me.SButton9.BorderSize = 0
        Me.SButton9.FlatAppearance.BorderSize = 0
        Me.SButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton9.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.SButton9.ForeColor = System.Drawing.Color.Black
        Me.SButton9.Image = Global.SipaaOS.My.Resources.Resources.icons8_microsoft_paint_32
        Me.SButton9.Location = New System.Drawing.Point(303, 68)
        Me.SButton9.Name = "SButton9"
        Me.SButton9.Size = New System.Drawing.Size(90, 90)
        Me.SButton9.TabIndex = 9
        Me.SButton9.Text = "Paint"
        Me.SButton9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.SButton9.UseVisualStyleBackColor = False
        '
        'SButton8
        '
        Me.SButton8.BackColor = System.Drawing.Color.Transparent
        Me.SButton8.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton8.BorderRadius = 6
        Me.SButton8.BorderSize = 0
        Me.SButton8.FlatAppearance.BorderSize = 0
        Me.SButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton8.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.SButton8.ForeColor = System.Drawing.Color.Black
        Me.SButton8.Image = Global.SipaaOS.My.Resources.Resources.icons8_notepad_32
        Me.SButton8.Location = New System.Drawing.Point(207, 68)
        Me.SButton8.Name = "SButton8"
        Me.SButton8.Size = New System.Drawing.Size(90, 90)
        Me.SButton8.TabIndex = 8
        Me.SButton8.Text = "Notepad"
        Me.SButton8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.SButton8.UseVisualStyleBackColor = False
        '
        'SButton7
        '
        Me.SButton7.BackColor = System.Drawing.Color.Transparent
        Me.SButton7.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton7.BorderRadius = 6
        Me.SButton7.BorderSize = 0
        Me.SButton7.FlatAppearance.BorderSize = 0
        Me.SButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton7.ForeColor = System.Drawing.Color.Black
        Me.SButton7.Image = Global.SipaaOS.My.Resources.Resources.icons8_restart_48
        Me.SButton7.Location = New System.Drawing.Point(305, 401)
        Me.SButton7.Name = "SButton7"
        Me.SButton7.Size = New System.Drawing.Size(46, 47)
        Me.SButton7.TabIndex = 7
        Me.SButton7.UseVisualStyleBackColor = False
        '
        'SButton6
        '
        Me.SButton6.BackColor = System.Drawing.Color.Transparent
        Me.SButton6.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton6.BorderRadius = 6
        Me.SButton6.BorderSize = 0
        Me.SButton6.FlatAppearance.BorderSize = 0
        Me.SButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton6.ForeColor = System.Drawing.Color.Black
        Me.SButton6.Image = Global.SipaaOS.My.Resources.Resources.icons8_logout_rounded_down_48
        Me.SButton6.Location = New System.Drawing.Point(253, 401)
        Me.SButton6.Name = "SButton6"
        Me.SButton6.Size = New System.Drawing.Size(46, 47)
        Me.SButton6.TabIndex = 6
        Me.SButton6.UseVisualStyleBackColor = False
        '
        'SButton5
        '
        Me.SButton5.BackColor = System.Drawing.Color.Transparent
        Me.SButton5.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton5.BorderRadius = 6
        Me.SButton5.BorderSize = 0
        Me.SButton5.FlatAppearance.BorderSize = 0
        Me.SButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton5.ForeColor = System.Drawing.Color.Black
        Me.SButton5.Image = Global.SipaaOS.My.Resources.Resources.icons8_shutdown_48
        Me.SButton5.Location = New System.Drawing.Point(357, 401)
        Me.SButton5.Name = "SButton5"
        Me.SButton5.Size = New System.Drawing.Size(46, 47)
        Me.SButton5.TabIndex = 5
        Me.SButton5.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(9, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Username"
        '
        'SButton3
        '
        Me.SButton3.BackColor = System.Drawing.Color.Transparent
        Me.SButton3.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton3.BorderRadius = 6
        Me.SButton3.BorderSize = 0
        Me.SButton3.FlatAppearance.BorderSize = 0
        Me.SButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SButton3.ForeColor = System.Drawing.Color.Black
        Me.SButton3.Image = Global.SipaaOS.My.Resources.Resources.explorer32
        Me.SButton3.Location = New System.Drawing.Point(111, 66)
        Me.SButton3.Name = "SButton3"
        Me.SButton3.Size = New System.Drawing.Size(90, 90)
        Me.SButton3.TabIndex = 3
        Me.SButton3.Text = "File Explorer"
        Me.SButton3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.SButton3.UseVisualStyleBackColor = False
        '
        'SButton2
        '
        Me.SButton2.BackColor = System.Drawing.Color.Transparent
        Me.SButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton2.BorderRadius = 6
        Me.SButton2.BorderSize = 0
        Me.SButton2.FlatAppearance.BorderSize = 0
        Me.SButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton2.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.SButton2.ForeColor = System.Drawing.Color.Black
        Me.SButton2.Image = Global.SipaaOS.My.Resources.Resources.icons8_settings_32
        Me.SButton2.Location = New System.Drawing.Point(15, 68)
        Me.SButton2.Name = "SButton2"
        Me.SButton2.Size = New System.Drawing.Size(90, 90)
        Me.SButton2.TabIndex = 2
        Me.SButton2.Text = "Settings"
        Me.SButton2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.SButton2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text", 14.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Build-In Applications"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 20)
        Me.TextBox1.TabIndex = 0
        '
        'SystemTimer
        '
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SipaaOS.My.Resources.Resources.sipaabg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1228, 702)
        Me.Controls.Add(Me.SPanel2)
        Me.Controls.Add(Me.SPanel1)
        Me.DoubleBuffered = True
        Me.Name = "Desktop"
        Me.Text = "Desktop"
        Me.SPanel1.ResumeLayout(False)
        Me.SPanel1.PerformLayout()
        Me.SPanel3.ResumeLayout(False)
        Me.SPanel2.ResumeLayout(False)
        Me.SPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SPanel1 As Sipaa.Framework.SPanel
    Friend WithEvents SButton1 As Sipaa.Framework.SButton
    Friend WithEvents SPanel2 As Sipaa.Framework.SPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SystemTimer As Timer
    Friend WithEvents SButton2 As Sipaa.Framework.SButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SButton3 As Sipaa.Framework.SButton
    Friend WithEvents SPanel3 As Sipaa.Framework.SPanel
    Friend WithEvents SButton4 As Sipaa.Framework.SButton
    Friend WithEvents SButton7 As Sipaa.Framework.SButton
    Friend WithEvents SButton6 As Sipaa.Framework.SButton
    Friend WithEvents SButton5 As Sipaa.Framework.SButton
    Friend WithEvents Label4 As Label
    Friend WithEvents SButton8 As Sipaa.Framework.SButton
    Friend WithEvents SButton9 As Sipaa.Framework.SButton
End Class
