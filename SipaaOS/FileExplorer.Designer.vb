<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileExplorer
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
        Me.SPanel2 = New Sipaa.Framework.SPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SButton1 = New Sipaa.Framework.SButton()
        Me.SPanel1 = New Sipaa.Framework.SPanel()
        Me.SButton2 = New Sipaa.Framework.SButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SButton3 = New Sipaa.Framework.SButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SButton4 = New Sipaa.Framework.SButton()
        Me.SEllipse1 = New Sipaa.Framework.SEllipse()
        Me.SPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SPanel2
        '
        Me.SPanel2.BackColor = System.Drawing.Color.Snow
        Me.SPanel2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel2.BorderRadius = 0
        Me.SPanel2.BorderSize = 0
        Me.SPanel2.Controls.Add(Me.PictureBox1)
        Me.SPanel2.Controls.Add(Me.Label1)
        Me.SPanel2.Controls.Add(Me.SButton1)
        Me.SPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SPanel2.ForeColor = System.Drawing.Color.White
        Me.SPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SPanel2.Name = "SPanel2"
        Me.SPanel2.Size = New System.Drawing.Size(1103, 48)
        Me.SPanel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.SipaaOS.My.Resources.Resources.explorer32
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(60, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File Explorer"
        '
        'SButton1
        '
        Me.SButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SButton1.BackColor = System.Drawing.Color.Transparent
        Me.SButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton1.BorderRadius = 6
        Me.SButton1.BorderSize = 0
        Me.SButton1.FlatAppearance.BorderSize = 0
        Me.SButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.SButton1.ForeColor = System.Drawing.Color.Black
        Me.SButton1.Location = New System.Drawing.Point(1046, 3)
        Me.SButton1.Name = "SButton1"
        Me.SButton1.Size = New System.Drawing.Size(54, 42)
        Me.SButton1.TabIndex = 0
        Me.SButton1.Text = "X"
        Me.SButton1.UseVisualStyleBackColor = False
        '
        'SPanel1
        '
        Me.SPanel1.BackColor = System.Drawing.Color.Snow
        Me.SPanel1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel1.BorderRadius = 0
        Me.SPanel1.BorderSize = 0
        Me.SPanel1.Controls.Add(Me.SButton4)
        Me.SPanel1.Controls.Add(Me.TextBox1)
        Me.SPanel1.Controls.Add(Me.SButton3)
        Me.SPanel1.Controls.Add(Me.SButton2)
        Me.SPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SPanel1.ForeColor = System.Drawing.Color.White
        Me.SPanel1.Location = New System.Drawing.Point(0, 48)
        Me.SPanel1.Name = "SPanel1"
        Me.SPanel1.Size = New System.Drawing.Size(1103, 48)
        Me.SPanel1.TabIndex = 1
        '
        'SButton2
        '
        Me.SButton2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.SButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton2.BorderRadius = 6
        Me.SButton2.BorderSize = 0
        Me.SButton2.FlatAppearance.BorderSize = 0
        Me.SButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SButton2.ForeColor = System.Drawing.Color.White
        Me.SButton2.Location = New System.Drawing.Point(4, 3)
        Me.SButton2.Name = "SButton2"
        Me.SButton2.Size = New System.Drawing.Size(44, 42)
        Me.SButton2.TabIndex = 0
        Me.SButton2.Text = "<"
        Me.SButton2.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 96)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1103, 591)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("C:\Users", System.UriKind.Absolute)
        '
        'SButton3
        '
        Me.SButton3.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.SButton3.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton3.BorderRadius = 6
        Me.SButton3.BorderSize = 0
        Me.SButton3.FlatAppearance.BorderSize = 0
        Me.SButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SButton3.ForeColor = System.Drawing.Color.White
        Me.SButton3.Location = New System.Drawing.Point(54, 3)
        Me.SButton3.Name = "SButton3"
        Me.SButton3.Size = New System.Drawing.Size(44, 42)
        Me.SButton3.TabIndex = 1
        Me.SButton3.Text = ">"
        Me.SButton3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(104, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(946, 42)
        Me.TextBox1.TabIndex = 2
        '
        'SButton4
        '
        Me.SButton4.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.SButton4.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton4.BorderRadius = 6
        Me.SButton4.BorderSize = 0
        Me.SButton4.FlatAppearance.BorderSize = 0
        Me.SButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton4.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.SButton4.ForeColor = System.Drawing.Color.White
        Me.SButton4.Location = New System.Drawing.Point(1056, 3)
        Me.SButton4.Name = "SButton4"
        Me.SButton4.Size = New System.Drawing.Size(44, 42)
        Me.SButton4.TabIndex = 3
        Me.SButton4.Text = "Go"
        Me.SButton4.UseVisualStyleBackColor = False
        '
        'SEllipse1
        '
        Me.SEllipse1.CornerRadius = 6
        Me.SEllipse1.TargetControl = Me.TextBox1
        '
        'FileExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1103, 687)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.SPanel1)
        Me.Controls.Add(Me.SPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FileExplorer"
        Me.Text = "About"
        Me.SPanel2.ResumeLayout(False)
        Me.SPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SPanel1.ResumeLayout(False)
        Me.SPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SPanel2 As Sipaa.Framework.SPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SButton1 As Sipaa.Framework.SButton
    Friend WithEvents SPanel1 As Sipaa.Framework.SPanel
    Friend WithEvents SButton2 As Sipaa.Framework.SButton
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SButton3 As Sipaa.Framework.SButton
    Friend WithEvents SButton4 As Sipaa.Framework.SButton
    Friend WithEvents SEllipse1 As Sipaa.Framework.SEllipse
End Class
