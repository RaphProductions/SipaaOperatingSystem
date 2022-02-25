Imports System.IO
Imports Sipaa.Framework

Public Class Desktop
    Public logged As Boolean = False
    Public guest As Boolean = False
    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    Private Sub SButton1_Click(sender As Object, e As EventArgs) Handles SButton1.Click
        Try
            'About.Show()
            If SPanel2.Visible = True Then
                SPanel2.Hide()
            Else
                SPanel2.Show()
            End If
        Catch ex As Exception
            PSOD.Show()
            Me.Close()
        End Try
    End Sub
    Public Sub ShowSODE()
        SPanel1.Show()
    End Sub
    Public Sub HideSODE()
        SPanel1.Hide()
    End Sub
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        Try
            InitializeComponent()
        Catch ex As Exception
            PSOD.Show()
            Me.Close()
        End Try

        ' Theme system
        Dim this = Me
        this.FormBorderStyle = FormBorderStyle.None
        this.Size = Screen.PrimaryScreen.WorkingArea.Size
        this.Location = New Point(0, 0)
        If guest = True Then
                Label4.Text = "Guest"
            Else
                Label4.Text = My.Settings.Username
            End If
            If File.Exists(My.Settings.BackgroundLocation) = False Then
                Me.BackgroundImage = My.Resources.sipaabg
            Else
                Me.BackgroundImage = Image.FromFile(My.Settings.BackgroundLocation)
            End If
            If My.Settings.EnableSaero = True Then
                If My.Settings.Theme = "Light" Then
                    ' Apply color for the panels and labels
                    SPanel1.BackColor = Color.FromArgb(147, 255, 255, 255)
                    SPanel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    SPanel2.BackColor = Color.FromArgb(147, 255, 255, 255)
                    SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    ' Apply color for the buttons
                    SButton1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    SButton2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    SButton3.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Else
                    ' Apply color for the panels and labels
                    SPanel1.BackColor = Color.FromArgb(147, 0, 0, 0)
                    SPanel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    SPanel2.BackColor = Color.FromArgb(147, 0, 0, 0)
                    SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    ' Apply color for the buttons
                    SButton1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    SButton2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    SButton3.ForeColor = Color.FromArgb(255, 255, 255, 255)
                End If
            Else
                If My.Settings.Theme = "Light" Then
                    ' Apply color for the panels and labels
                    SPanel1.BackColor = Color.FromArgb(255, 255, 255, 255)
                    SPanel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    SPanel2.BackColor = Color.FromArgb(255, 255, 255, 255)
                    SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    ' Apply color for the buttons
                    SButton1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    SButton2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    SButton3.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Else
                    ' Apply color for the panels and labels
                    SPanel1.BackColor = Color.FromArgb(255, 0, 0, 0)
                    SPanel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    SPanel2.BackColor = Color.FromArgb(255, 0, 0, 0)
                    SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    ' Apply color for the buttons
                    SButton1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    SButton2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                    SButton3.ForeColor = Color.FromArgb(255, 255, 255, 255)
                End If
            End If
            Label2.Text = DateTime.Now.ToString("HH:mm")
            Label3.Text = DateTime.Now.ToString("dd/MM/yyyy")
            If logged = False Then
                HideSODE()
                Login.TopLevel = False
                Login.TopMost = False
                Me.Controls.Add(Login)
                Login.Location = New Point(Me.Width / 2 - Login.Width / 2, Me.Height / 2 - Login.Height / 2)
                Login.Show()
            End If
            SystemTimer.Start()
    End Sub

    Private Sub SystemTimer_Tick(sender As Object, e As EventArgs) Handles SystemTimer.Tick
        Dim settings = My.Settings
        ' Update the time and date
        Label2.Text = DateTime.Now.ToString("HH:mm")
        Label3.Text = DateTime.Now.ToString("dd/MM/yyyy")
        ' Verify if the user is a guest
        If guest = True Then
            Label4.Text = "Guest"
        Else
            Label4.Text = My.Settings.Username
        End If
        ' Theme system
        If My.Settings.EnableSaero = True Then
            If My.Settings.Theme = "Light" Then
                ' Apply color for the panels and labels
                SPanel1.BackColor = Color.FromArgb(147, 255, 255, 255)
                SPanel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SPanel2.BackColor = Color.FromArgb(147, 255, 255, 255)
                SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                ' Apply color for the buttons
                SButton1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton8.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton9.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton10.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Else
                ' Apply color for the panels and labels
                SPanel1.BackColor = Color.FromArgb(147, 0, 0, 0)
                SPanel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SPanel2.BackColor = Color.FromArgb(147, 0, 0, 0)
                SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Label2.ForeColor = Color.White
                Label3.ForeColor = Color.White
                ' Apply color for the buttons
                SButton1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton3.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton8.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton9.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton10.ForeColor = Color.FromArgb(255, 255, 255, 255)
            End If
        Else
            If My.Settings.Theme = "Light" Then
                ' Apply color for the panels and labels
                SPanel1.BackColor = Color.FromArgb(255, 255, 255, 255)
                SPanel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SPanel2.BackColor = Color.FromArgb(255, 255, 255, 255)
                SPanel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Label2.ForeColor = Color.Black
                Label3.ForeColor = Color.Black
                ' Apply color for the buttons
                SButton1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton3.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton9.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton8.ForeColor = Color.FromArgb(255, 0, 0, 0)
                SButton10.ForeColor = Color.FromArgb(255, 0, 0, 0)
            Else
                ' Apply color for the panels and labels
                SPanel1.BackColor = Color.FromArgb(255, 0, 0, 0)
                SPanel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SPanel2.BackColor = Color.FromArgb(255, 0, 0, 0)
                SPanel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Label2.ForeColor = Color.White
                Label3.ForeColor = Color.White
                ' Apply color for the buttons
                SButton1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton3.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton8.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton9.ForeColor = Color.FromArgb(255, 255, 255, 255)
                SButton10.ForeColor = Color.FromArgb(255, 255, 255, 255)
            End If
        End If

    End Sub
    Public Function OpenAppOnOS(obj As Form) As Boolean
        Try
            obj.Show()
            SPanel2.Hide()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function OpenApp(frm As Form) As Boolean
        Try
            frm.TopLevel = False
            frm.TopMost = False
            Me.Controls.Add(frm)
            frm.Location = New Point(Me.Width / 2 - frm.Width / 2, Me.Height / 2 - frm.Height / 2)
            frm.Show()
            SPanel2.Hide()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function OpenDialog(frm As Form) As Boolean
        Try
            frm.TopLevel = False
            frm.TopMost = False
            Me.Controls.Add(frm)
            frm.Location = New Point(Me.Width / 2 - frm.Width / 2, Me.Height / 2 - frm.Height / 2)
            frm.ShowDialog()
            SPanel2.Hide()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub SButton2_Click(sender As Object, e As EventArgs) Handles SButton2.Click
        If guest = True Then
            MsgBox.Show("SODE", "For security , you cannot open this app into guest mode.", MsgBoxType.Information)
        Else
            OpenApp(Settings)
        End If
    End Sub

    Private Sub SButton3_Click(sender As Object, e As EventArgs) Handles SButton3.Click
        OpenApp(FileExplorer)
    End Sub

    Private Sub SButton4_Click(sender As Object, e As EventArgs) Handles SButton4.Click
        OpenApp(FileExplorer)
    End Sub

    Private Sub RunProc(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "" Then
                MsgBox.Show("SipaaOS", "Nothing to run.", MsgBoxType.Information)
                TextBox1.Clear()
            Else
                MsgBox.Show("SipaaOS Subsystem for Windows", "SipaaOS has compatibility problems with others Windows Apps and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows 10/11 UWP Apps. Click OK to run.", MsgBoxType.Warning)
                Dim p As System.Diagnostics.Process
                p = Process.Start(TextBox1.Text)
                'If gui = True Then
                p.WaitForInputIdle()
                'End If
                SetParent(p.MainWindowHandle, Me.Handle)
                SendMessage(p.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
                Me.BringToFront()
                SPanel2.Hide()
            End If
        End If
    End Sub

    Private Sub SButton5_Click(sender As Object, e As EventArgs) Handles SButton5.Click
        Environment.Exit(0)
    End Sub

    Private Sub SButton7_Click(sender As Object, e As EventArgs) Handles SButton7.Click
        Boot.Show()
        Me.Close()
    End Sub

    Private Sub SButton6_Click(sender As Object, e As EventArgs) Handles SButton6.Click
        HideSODE()
        logged = False
        guest = False
        OpenApp(Login)
    End Sub

    Private Sub SButton8_Click(sender As Object, e As EventArgs) Handles SButton8.Click
        OpenApp(Notepad)
    End Sub

    Private Sub SButton9_Click(sender As Object, e As EventArgs) Handles SButton9.Click
        OpenApp(SipaaOS.Paint)
    End Sub

    Private Sub SButton11_Click(sender As Object, e As EventArgs) Handles SButton11.Click
        OpenApp(SedgeTabHandler)
    End Sub

    Private Sub SButton10_Click(sender As Object, e As EventArgs) Handles SButton10.Click
        OpenApp(SedgeTabHandler)
    End Sub

    Private Sub TopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopToolStripMenuItem.Click
        SPanel1.Dock = DockStyle.Top
        SPanel2.Location = New Point(3, 43)
    End Sub

    Private Sub BottomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomToolStripMenuItem.Click
        SPanel1.Dock = DockStyle.Bottom
        SPanel2.Location = New Point(3, Me.Width - 43)
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click
        If FullScreenToolStripMenuItem.Checked = True Then
            SPanel1.Dock = DockStyle.Bottom
            SPanel2.Location = New Point(3, Me.Width - SPanel2.Width - 43)
        End If
    End Sub
End Class
