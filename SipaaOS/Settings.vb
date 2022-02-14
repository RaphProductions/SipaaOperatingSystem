Imports System.Runtime.InteropServices

Public Class Settings
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

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SPanel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub SButton1_Click(sender As Object, e As EventArgs) Handles SButton1.Click
        Close()
    End Sub
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Universal SipaaOS Platform Main Components
        Me.FormBorderStyle = FormBorderStyle.None
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, cornerradius, cornerradius))

        ' Sets the app theme
        If My.Settings.Theme = "Light" Then
            SPanel2.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Me.BackColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.Black
            SButton2.ForeColor = Color.Black
            SButton3.ForeColor = Color.Black
            SButton4.ForeColor = Color.Black
            SButton5.ForeColor = Color.Black
            SButton7.ForeColor = Color.Black
            SButton6.ForeColor = Color.Black
            SButton8.ForeColor = Color.Black
            SButton9.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
        Else
            SPanel2.BackColor = Color.FromArgb(255, 100, 100, 100)
            Label1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.BackColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.White
            SButton2.ForeColor = Color.White
            SButton3.ForeColor = Color.White
            SButton4.ForeColor = Color.White
            SButton5.ForeColor = Color.White
            SButton7.ForeColor = Color.White
            SButton6.ForeColor = Color.White
            SButton8.ForeColor = Color.White
            SButton9.ForeColor = Color.White
            Label1.ForeColor = Color.White
        End If
    End Sub
    Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
        My.Settings.Theme = "Light"
        SPanel2.BackColor = Color.FromArgb(255, 255, 250, 250)
        SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
        Label1.ForeColor = Color.Black
        Me.BackColor = Color.FromArgb(255, 255, 255, 255)
        Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
        SButton1.ForeColor = Color.Black
        SButton2.ForeColor = Color.Black
        SButton3.ForeColor = Color.Black
        SButton4.ForeColor = Color.Black
        SButton5.ForeColor = Color.Black
        SButton6.ForeColor = Color.Black
        SButton7.ForeColor = Color.Black
        SButton8.ForeColor = Color.Black
        SButton9.ForeColor = Color.Black
    End Sub

    Private Sub SButton3_Click(sender As Object, e As EventArgs) Handles SButton3.Click
        My.Settings.Theme = "Dark"
        ' Sets the theme for the Settings app
        SPanel2.BackColor = Color.FromArgb(255, 100, 100, 100)
        SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Me.BackColor = Color.FromArgb(255, 0, 0, 0)
        SButton1.ForeColor = Color.White
        SButton2.ForeColor = Color.White
        SButton3.ForeColor = Color.White
        SButton4.ForeColor = Color.White
        SButton5.ForeColor = Color.White
        SButton7.ForeColor = Color.White
        SButton8.ForeColor = Color.White
        SButton9.ForeColor = Color.White
        Label1.ForeColor = Color.White
        SButton6.ForeColor = Color.White
    End Sub

    Private Sub SButton4_Click(sender As Object, e As EventArgs) Handles SButton4.Click
        Desktop.OpenApp(About)
    End Sub

    Private Sub SButton6_Click(sender As Object, e As EventArgs) Handles SButton6.Click
        My.Settings.EnableSaero = True
    End Sub

    Private Sub SButton5_Click(sender As Object, e As EventArgs) Handles SButton5.Click
        My.Settings.EnableSaero = False
    End Sub

    Private Sub SButton7_Click(sender As Object, e As EventArgs) Handles SButton7.Click
        Dim dialog As New OpenFileDialog
        dialog.InitialDirectory = Environment.SpecialFolder.MyPictures
        dialog.Filter = "PNG files|*.png|JPG files|*.jpg|BMP files|*.bmp|JPEG files|*.jpeg|GIF files|*.gif"
        If dialog.ShowDialog() = DialogResult.OK Then
            My.Settings.BackgroundLocation = dialog.FileName
            Desktop.BackgroundImage = Image.FromFile(dialog.FileName)
            MsgBox.Show("SipaaOS Wallpaper Service", "You wallpaper has been applied sucessfully", MsgBoxType.Sucess)
        End If
    End Sub

    Private Sub SButton8_Click(sender As Object, e As EventArgs) Handles SButton8.Click
        My.Settings.Username = TextBox1.Text
        TextBox1.Clear()
        MessageBox.Show("Your username has been applied sucessfully!", "SipaaOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SButton9_Click(sender As Object, e As EventArgs) Handles SButton9.Click
        My.Settings.Password = TextBox2.Text
        TextBox2.Clear()
        MessageBox.Show("Your password has been applied sucessfully!", "SipaaOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class