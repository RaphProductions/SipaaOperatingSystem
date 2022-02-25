Imports System.Runtime.InteropServices

Public Class Login
    Public cornerradius As Integer = 11
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, cornerradius, cornerradius))
        PictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PictureBox1.Width, PictureBox1.Height, 60, 60))
        Label1.Text = My.Settings.Username
        Label1.Location = SODEUtils.GetCenterWidth(Me, Label1)
        Label3.Location = SODEUtils.GetCenterWidth(Me, Label3)
        PictureBox1.Location = SODEUtils.GetCenterWidth(Me, PictureBox1)
        TextBox1.Location = SODEUtils.GetCenterWidth(Me, TextBox1)
        SButton2.Location = SODEUtils.GetCenterWidth(Me, SButton2)
        If My.Settings.Theme = "Light" Then
            Me.BackColor = Color.FromArgb(255, 255, 255, 255)
            Me.TransparencyKey = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SButton2.ForeColor = Color.Black
            SButton2.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        Else
            Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.TransparencyKey = Color.FromArgb(255, 0, 0, 0)
            Me.BackColor = Color.FromArgb(255, 0, 0, 0)
            SButton2.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Label3.ForeColor = Color.White
        End If
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
        End If
    End Sub
    Private Sub SButton1_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

    Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
        If TextBox1.Text = My.Settings.Password Then
            Desktop.logged = True
            Desktop.ShowSODE()
            Me.Close()
        Else
            MsgBox.Show("SipaaOS", "Your password is incorrect. Are you a hacker?", MsgBoxType.SError)
        End If
    End Sub

    Private Sub SButton3_Click(sender As Object, e As EventArgs) Handles LoginAsGuestToolStripMenuItem.Click
        Desktop.guest = True
        Desktop.logged = True
        Desktop.ShowSODE()
        Me.Close()
    End Sub
End Class