<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPick
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
        Me.SButton2 = New Sipaa.Framework.SButton()
        Me.ColorWheel1 = New Cyotek.Windows.Forms.ColorWheel()
        Me.SButton1 = New Sipaa.Framework.SButton()
        Me.SPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SPanel2
        '
        Me.SPanel2.BackColor = System.Drawing.Color.Snow
        Me.SPanel2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SPanel2.BorderRadius = 0
        Me.SPanel2.BorderSize = 0
        Me.SPanel2.Controls.Add(Me.Label1)
        Me.SPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SPanel2.ForeColor = System.Drawing.Color.White
        Me.SPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SPanel2.Name = "SPanel2"
        Me.SPanel2.Size = New System.Drawing.Size(335, 48)
        Me.SPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color Picker"
        '
        'SButton2
        '
        Me.SButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SButton2.BackColor = System.Drawing.Color.Snow
        Me.SButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton2.BorderRadius = 6
        Me.SButton2.BorderSize = 0
        Me.SButton2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SButton2.FlatAppearance.BorderSize = 0
        Me.SButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SButton2.ForeColor = System.Drawing.Color.Black
        Me.SButton2.Location = New System.Drawing.Point(261, 372)
        Me.SButton2.Name = "SButton2"
        Me.SButton2.Size = New System.Drawing.Size(62, 40)
        Me.SButton2.TabIndex = 3
        Me.SButton2.Text = "OK"
        Me.SButton2.UseVisualStyleBackColor = False
        '
        'ColorWheel1
        '
        Me.ColorWheel1.Alpha = 1.0R
        Me.ColorWheel1.Location = New System.Drawing.Point(17, 54)
        Me.ColorWheel1.Name = "ColorWheel1"
        Me.ColorWheel1.Size = New System.Drawing.Size(304, 317)
        Me.ColorWheel1.TabIndex = 4
        '
        'SButton1
        '
        Me.SButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SButton1.BackColor = System.Drawing.Color.Snow
        Me.SButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton1.BorderRadius = 6
        Me.SButton1.BorderSize = 0
        Me.SButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SButton1.FlatAppearance.BorderSize = 0
        Me.SButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SButton1.ForeColor = System.Drawing.Color.Black
        Me.SButton1.Location = New System.Drawing.Point(169, 372)
        Me.SButton1.Name = "SButton1"
        Me.SButton1.Size = New System.Drawing.Size(86, 40)
        Me.SButton1.TabIndex = 5
        Me.SButton1.Text = "Cancel"
        Me.SButton1.UseVisualStyleBackColor = False
        '
        'ColorPick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 424)
        Me.Controls.Add(Me.SButton1)
        Me.Controls.Add(Me.ColorWheel1)
        Me.Controls.Add(Me.SButton2)
        Me.Controls.Add(Me.SPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ColorPick"
        Me.Text = "About"
        Me.SPanel2.ResumeLayout(False)
        Me.SPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SPanel2 As Sipaa.Framework.SPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SButton2 As Sipaa.Framework.SButton
    Friend WithEvents ColorWheel1 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents SButton1 As Sipaa.Framework.SButton
End Class
