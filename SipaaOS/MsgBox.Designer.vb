<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBox
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
        Me.SPanel2 = New Sipaa.Framework.SPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SButton1 = New Sipaa.Framework.SButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SButton2 = New Sipaa.Framework.SButton()
        Me.SPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPanel2
        '
        Me.SPanel2.BackColor = System.Drawing.Color.Snow
        Me.SPanel2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel2.BorderRadius = 0
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
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MessageBoxTitle"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SipaaOS.My.Resources.Resources.icons8_info_48
        Me.PictureBox1.Location = New System.Drawing.Point(15, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(85, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MessageBoxText"
        '
        'SButton2
        '
        Me.SButton2.BackColor = System.Drawing.Color.Snow
        Me.SButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton2.BorderRadius = 6
        Me.SButton2.BorderSize = 0
        Me.SButton2.FlatAppearance.BorderSize = 0
        Me.SButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SButton2.ForeColor = System.Drawing.Color.Black
        Me.SButton2.Location = New System.Drawing.Point(497, 223)
        Me.SButton2.Name = "SButton2"
        Me.SButton2.Size = New System.Drawing.Size(63, 40)
        Me.SButton2.TabIndex = 3
        Me.SButton2.Text = "OK"
        Me.SButton2.UseVisualStyleBackColor = False
        '
        'MsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(572, 275)
        Me.Controls.Add(Me.SButton2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MsgBox"
        Me.Text = "About"
        Me.SPanel2.ResumeLayout(False)
        Me.SPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SPanel2 As Sipaa.Framework.SPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SButton1 As Sipaa.Framework.SButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SButton2 As Sipaa.Framework.SButton
End Class
