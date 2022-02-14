Imports System.Runtime.InteropServices

Public Class Paint
    ' Paint Variables
    Dim g As Graphics
    Dim p As Pen
    Dim draw As Boolean
    Dim beginX, beginY As Integer
    ' Universal Sipaa Platform
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
        g = DrawPanel.CreateGraphics()
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        ' Sets the app theme
        If My.Settings.Theme = "Light" Then
            SPanel2.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SPanel1.BackColor = Color.FromArgb(255, 255, 250, 250)
            SPanel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Me.BackColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.Black
            SButton2.ForeColor = Color.Black
            SButton3.ForeColor = Color.Black
            SButton4.ForeColor = Color.Black
            p = New Pen(Color.Black, 2)
        Else
            SPanel2.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            SPanel1.BackColor = Color.FromArgb(255, 100, 100, 100)
            SPanel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Label1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Label2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Label3.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Me.BackColor = Color.FromArgb(255, 0, 0, 0)
            SButton1.ForeColor = Color.White
            SButton2.ForeColor = Color.White
            SButton3.ForeColor = Color.White
            SButton4.ForeColor = Color.White
            p = New Pen(Color.White, 2)
        End If
        SPanel3.BackColor = p.Color
    End Sub

    Private Sub DrawPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawPanel.MouseDown
        draw = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub DrawPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles DrawPanel.MouseUp
        draw = False
    End Sub

    Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
        Dim dialog As New ColorDialog
        If dialog.ShowDialog() = DialogResult.OK Then
            p.Color = dialog.Color
            SPanel3.BackColor = dialog.Color
        End If
    End Sub

    Private Sub SButton3_Click(sender As Object, e As EventArgs) Handles SButton3.Click
        p.Width = p.Width + 1
        Label3.Text = "Pen Size : " + p.Width.ToString()
    End Sub

    Private Sub SButton4_Click(sender As Object, e As EventArgs) Handles SButton4.Click
        p.Width = p.Width - 1
        Label3.Text = "Pen Size : " + p.Width.ToString()
    End Sub

    Private Sub DrawPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawPanel.MouseMove
        Dim point1 As New Point(beginX, beginY)
        Dim point2 As New Point(e.X, e.Y)
        If draw = True Then
            g.DrawLine(p, point1, point2)
            beginX = e.X
            beginY = e.Y
        End If
    End Sub
End Class