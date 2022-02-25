<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SedgeTabHandler
    Inherits Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SButton1 = New Sipaa.Framework.SButton()
        Me.MetroTabControl = New TabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.SButton2 = New Sipaa.Framework.SButton()
        Me.SButton3 = New Sipaa.Framework.SButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SPanel2.SuspendLayout()
        Me.MetroTabControl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPanel2
        '
        Me.SPanel2.BackColor = System.Drawing.Color.Snow
        Me.SPanel2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel2.BorderRadius = 0
        Me.SPanel2.BorderSize = 0
        Me.SPanel2.Controls.Add(Me.SButton3)
        Me.SPanel2.Controls.Add(Me.SButton2)
        Me.SPanel2.Controls.Add(Me.PictureBox1)
        Me.SPanel2.Controls.Add(Me.Label1)
        Me.SPanel2.Controls.Add(Me.SButton1)
        Me.SPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SPanel2.ForeColor = System.Drawing.Color.White
        Me.SPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SPanel2.Name = "SPanel2"
        Me.SPanel2.Size = New System.Drawing.Size(1103, 48)
        Me.SPanel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(60, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sipaa Edge"
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
        'MetroTabControl
        '
        Me.MetroTabControl.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl.Location = New System.Drawing.Point(0, 48)
        Me.MetroTabControl.Multiline = True
        Me.MetroTabControl.Name = "MetroTabControl"
        Me.MetroTabControl.SelectedIndex = 0
        Me.MetroTabControl.Size = New System.Drawing.Size(1103, 639)
        Me.MetroTabControl.TabIndex = 3
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1095, 600)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "MetroTabPage1"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        '
        'SButton2
        '
        Me.SButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SButton2.BackColor = System.Drawing.Color.Transparent
        Me.SButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton2.BorderRadius = 6
        Me.SButton2.BorderSize = 0
        Me.SButton2.FlatAppearance.BorderSize = 0
        Me.SButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.SButton2.ForeColor = System.Drawing.Color.Black
        Me.SButton2.Location = New System.Drawing.Point(1002, 3)
        Me.SButton2.Name = "SButton2"
        Me.SButton2.Size = New System.Drawing.Size(38, 42)
        Me.SButton2.TabIndex = 3
        Me.SButton2.Text = "+"
        Me.SButton2.UseVisualStyleBackColor = False
        '
        'SButton3
        '
        Me.SButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SButton3.BackColor = System.Drawing.Color.Transparent
        Me.SButton3.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton3.BorderRadius = 6
        Me.SButton3.BorderSize = 0
        Me.SButton3.FlatAppearance.BorderSize = 0
        Me.SButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.SButton3.ForeColor = System.Drawing.Color.Black
        Me.SButton3.Location = New System.Drawing.Point(958, 3)
        Me.SButton3.Name = "SButton3"
        Me.SButton3.Size = New System.Drawing.Size(38, 42)
        Me.SButton3.TabIndex = 4
        Me.SButton3.Text = "-"
        Me.SButton3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.SipaaOS.My.Resources.Resources.icons8_microsoft_edge_32
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SedgeTabHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1103, 687)
        Me.Controls.Add(Me.MetroTabControl)
        Me.Controls.Add(Me.SPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SedgeTabHandler"
        Me.Text = "About"
        Me.SPanel2.ResumeLayout(False)
        Me.SPanel2.PerformLayout()
        Me.MetroTabControl.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SPanel2 As Sipaa.Framework.SPanel
    Friend WithEvents SButton3 As Sipaa.Framework.SButton
    Friend WithEvents SButton2 As Sipaa.Framework.SButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SButton1 As Sipaa.Framework.SButton
    Friend WithEvents MetroTabControl As TabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
End Class
