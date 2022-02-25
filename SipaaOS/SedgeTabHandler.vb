Imports System.Runtime.InteropServices

Public Class SedgeTabHandler
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

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub SButton1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Universal SipaaOS Platform Main Components
        Me.FormBorderStyle = FormBorderStyle.None
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, cornerradius, cornerradius))
        MetroTabControl.TabPages.Remove(MetroTabControl.SelectedTab)
        ' Sets the app theme
        If My.Settings.Theme = "Light" Then
            SPanel2.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Label1.ForeColor = Color.Black
            Me.BackColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.Black
            SButton2.ForeColor = Color.Black
            SButton3.ForeColor = Color.Black
        Else
            SPanel2.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Label1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.BackColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.White
            SButton2.ForeColor = Color.White
            SButton3.ForeColor = Color.White
        End If
        AddTab()
    End Sub

    Public Sub AddTab()
        Dim frm As New SedgeWebBrowser
        Dim tab As New TabPage
        frm.TopLevel = False
        frm.TopMost = False
        tab.Controls.Add(frm)
        MetroTabControl.TabPages.Add(tab)
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Public Sub ChangeSelectedTabText(text As String)
        MetroTabControl.SelectedTab.Text = text
    End Sub

    Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
        AddTab()
    End Sub

    Private Sub SButton3_Click(sender As Object, e As EventArgs) Handles SButton3.Click
        If MetroTabControl.TabCount = 1 Then
            Me.Close()
        Else
            MetroTabControl.TabPages.Remove(MetroTabControl.SelectedTab)
        End If
    End Sub
End Class