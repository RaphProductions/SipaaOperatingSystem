Imports System.Runtime.InteropServices

Public Class FileExplorer
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
            SPanel1.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Label1.ForeColor = Color.Black
            Me.BackColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.Black
        Else
            SPanel2.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            SPanel1.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Label1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.BackColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub SButton4_Click(sender As Object, e As EventArgs) Handles SButton4.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = e.Url.ToString.Replace("file:///", "")
        Label1.Text = "File Explorer - " + e.Url.ToString.Replace("file:///", "")
    End Sub

    Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
        If WebBrowser1.CanGoBack = True Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub SButton3_Click(sender As Object, e As EventArgs) Handles SButton3.Click
        If WebBrowser1.CanGoForward = True Then
            WebBrowser1.GoForward()
        End If
    End Sub
End Class