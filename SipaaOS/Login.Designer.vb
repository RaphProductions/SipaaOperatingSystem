<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SButton2 = New Sipaa.Framework.SButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SipaaOSLoginOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoginAsGuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SEllipse1 = New Sipaa.Framework.SEllipse()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 3
        '
        'SButton2
        '
        Me.SButton2.BackColor = System.Drawing.Color.Transparent
        Me.SButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton2.BorderRadius = 6
        Me.SButton2.BorderSize = 0
        Me.SButton2.FlatAppearance.BorderSize = 0
        Me.SButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SButton2.ForeColor = System.Drawing.Color.Black
        Me.SButton2.Location = New System.Drawing.Point(12, 276)
        Me.SButton2.Name = "SButton2"
        Me.SButton2.Size = New System.Drawing.Size(309, 34)
        Me.SButton2.TabIndex = 2
        Me.SButton2.Text = "Login"
        Me.SButton2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(106, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "username"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SipaaOSLoginOptionsToolStripMenuItem, Me.ToolStripSeparator1, Me.LoginAsGuestToolStripMenuItem, Me.ShutdownToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(196, 76)
        '
        'SipaaOSLoginOptionsToolStripMenuItem
        '
        Me.SipaaOSLoginOptionsToolStripMenuItem.Name = "SipaaOSLoginOptionsToolStripMenuItem"
        Me.SipaaOSLoginOptionsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SipaaOSLoginOptionsToolStripMenuItem.Text = "SipaaOS Login Options"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'LoginAsGuestToolStripMenuItem
        '
        Me.LoginAsGuestToolStripMenuItem.Name = "LoginAsGuestToolStripMenuItem"
        Me.LoginAsGuestToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.LoginAsGuestToolStripMenuItem.Text = "Login as guest"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SipaaOS.My.Resources.Resources.user_192
        Me.PictureBox1.Location = New System.Drawing.Point(122, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'SEllipse1
        '
        Me.SEllipse1.CornerRadius = 60
        Me.SEllipse1.TargetControl = Me.PictureBox1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(333, 322)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SButton2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "About"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SButton2 As Sipaa.Framework.SButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SipaaOSLoginOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LoginAsGuestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SEllipse1 As Sipaa.Framework.SEllipse
End Class
