<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PSOD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SButton1 = New Sipaa.Framework.SButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 60.25!)
        Me.Label1.Location = New System.Drawing.Point(631, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 135)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "😥"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 292)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(588, 84)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Try to rebuild the kernel configuration file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(887, 42)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "The Sipaa Boot Loader can not find the kernel configuration file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SButton1
        '
        Me.SButton1.BackColor = System.Drawing.Color.White
        Me.SButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.SButton1.BorderRadius = 6
        Me.SButton1.BorderSize = 0
        Me.SButton1.FlatAppearance.BorderSize = 0
        Me.SButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton1.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.SButton1.ForeColor = System.Drawing.Color.Black
        Me.SButton1.Location = New System.Drawing.Point(556, 379)
        Me.SButton1.Name = "SButton1"
        Me.SButton1.Size = New System.Drawing.Size(351, 49)
        Me.SButton1.TabIndex = 4
        Me.SButton1.Text = "Rebuild kernel config."
        Me.SButton1.UseVisualStyleBackColor = False
        '
        'PSOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1497, 1037)
        Me.Controls.Add(Me.SButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.Name = "PSOD"
        Me.Text = "PSOD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SButton1 As Sipaa.Framework.SButton
End Class
