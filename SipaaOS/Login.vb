Imports System.Runtime.InteropServices

Public Class Login
    Public cornerradius As Integer = 11
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, cornerradius, cornerradius))
        Label1.Text = "SipaaOS - Login to " + My.Settings.Username
        If My.Settings.Theme = "Light" Then
            SPanel2.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SPanel1.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Me.BackColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.Black
            SButton2.ForeColor = Color.Black
            SButton2.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        Else
            SPanel2.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            SPanel1.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.BackColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.White
            SButton2.ForeColor = Color.White
            SButton3.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
        End If
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SPanel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub SButton1_Click(sender As Object, e As EventArgs) Handles SButton1.Click
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

    Private Sub SButton3_Click(sender As Object, e As EventArgs) Handles SButton3.Click
        Desktop.guest = True
        Desktop.logged = True
        Desktop.ShowSODE()
        Me.Close()
    End Sub
End Class