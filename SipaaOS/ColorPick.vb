Imports System.Runtime.InteropServices

Public Class ColorPick
    Public cornerradius As Integer = 11
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public selectedColor As Color
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
        If My.Settings.Theme = "Light" Then
            SPanel2.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Me.BackColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.Black
            SButton1.BackColor = Color.FromArgb(255, 255, 250, 250)
            SButton2.ForeColor = Color.Black
            SButton2.BackColor = Color.FromArgb(255, 255, 250, 250)
            Label1.ForeColor = Color.Black
        Else
            SPanel2.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.BackColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.White
            SButton1.BackColor = Color.FromArgb(255, 100, 100, 100)
            SButton2.ForeColor = Color.White
            SButton2.BackColor = Color.FromArgb(255, 100, 100, 100)
            Label1.ForeColor = Color.White
        End If
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SPanel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub SButton1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
        Close()
    End Sub

    Private Sub SButton1_Click_1(sender As Object, e As EventArgs) Handles SButton1.Click
        Close()
    End Sub

    Private Sub ColorWheel1_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel1.ColorChanged
        selectedColor = ColorWheel1.Color
    End Sub
End Class