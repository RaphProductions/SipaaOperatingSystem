<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SPanel1 = New Sipaa.Framework.SPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SPanel2 = New Sipaa.Framework.SPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SButton1 = New Sipaa.Framework.SButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SPanel1.SuspendLayout()
        Me.SPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SPanel1
        '
        Me.SPanel1.BackColor = System.Drawing.Color.Snow
        Me.SPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.SPanel1.BorderRadius = 0
        Me.SPanel1.BorderSize = 0
        Me.SPanel1.Controls.Add(Me.Label2)
        Me.SPanel1.Controls.Add(Me.SPanel2)
        Me.SPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SPanel1.ForeColor = System.Drawing.Color.White
        Me.SPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SPanel1.Name = "SPanel1"
        Me.SPanel1.Size = New System.Drawing.Size(572, 110)
        Me.SPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 29.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(195, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SipaaOS"
        '
        'SPanel2
        '
        Me.SPanel2.BackColor = System.Drawing.Color.Snow
        Me.SPanel2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel2.BorderRadius = 6
        Me.SPanel2.BorderSize = 0
        Me.SPanel2.Controls.Add(Me.Label1)
        Me.SPanel2.Controls.Add(Me.SButton1)
        Me.SPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SPanel2.ForeColor = System.Drawing.Color.White
        Me.SPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SPanel2.Name = "SPanel2"
        Me.SPanel2.Size = New System.Drawing.Size(572, 48)
        Me.SPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "About SipaaOS"
        '
        'SButton1
        '
        Me.SButton1.BackColor = System.Drawing.Color.Transparent
        Me.SButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton1.BorderRadius = 6
        Me.SButton1.BorderSize = 0
        Me.SButton1.FlatAppearance.BorderSize = 0
        Me.SButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.SButton1.ForeColor = System.Drawing.Color.Black
        Me.SButton1.Location = New System.Drawing.Point(515, 3)
        Me.SButton1.Name = "SButton1"
        Me.SButton1.Size = New System.Drawing.Size(54, 42)
        Me.SButton1.TabIndex = 0
        Me.SButton1.Text = "X"
        Me.SButton1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 175)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SipaaOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 17 Beta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Build 27319" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sipaa Framework 1.0.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sipaa Base System 1" &
    "1.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Designed with love ❤️ by RaphMar2021"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 160)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "News :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bug Patches : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The About window is outside SipaaOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and the News label" &
    " is not affected by the theme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adds :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Added a Custom Message Box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 466)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "About"
        Me.Text = "About"
        Me.SPanel1.ResumeLayout(False)
        Me.SPanel1.PerformLayout()
        Me.SPanel2.ResumeLayout(False)
        Me.SPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SPanel1 As Sipaa.Framework.SPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents SPanel2 As Sipaa.Framework.SPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SButton1 As Sipaa.Framework.SButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
