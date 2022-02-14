Imports System.IO
Imports System.Threading

Public Class Boot
    Dim LoaderVisible As Boolean = False
    Dim pbar As ProgressBar
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ' Sipaa Immersive Boot (added in build 27319)
        If File.Exists(My.Settings.BackgroundLocation) = False Then
            Me.BackgroundImage = My.Resources.sipaabg
        Else
            Me.BackgroundImage = Image.FromFile(My.Settings.BackgroundLocation)
        End If
        ' Others but necessary :)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = New Point(0, 0)
        Label1.Location = New Point(Me.Width / 2 - Label1.Width / 2, Label1.Location.Y)
        PictureBox1.Location = New Point(Me.Width / 2 - PictureBox1.Width / 2, PictureBox1.Location.Y)
        Cursor.Hide()
    End Sub

    Private Sub Form_Load(sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        pbar = New ProgressBar
        pbar.Visible = False
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If LoaderVisible = False Then
            Thread.Sleep(5000)
            PictureBox1.Image = My.Resources.Windows10ProgressRing
            LoaderVisible = True
        Else
            pbar.Increment(2)
            If pbar.Value = 100 Then
                Cursor.Show()
                Desktop.Show()
                Timer1.Stop()
                Me.Close()
            End If
        End If
    End Sub
End Class