Public Class PSOD
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Dim this = Me
        this.FormBorderStyle = FormBorderStyle.None
        this.Size = Screen.PrimaryScreen.WorkingArea.Size
        this.Location = New Point(0, 0)
    End Sub
End Class