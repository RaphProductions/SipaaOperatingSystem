Public Class PSOD
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Dim this = Me
        this.FormBorderStyle = FormBorderStyle.None
        this.Size = Screen.PrimaryScreen.WorkingArea.Size
        this.Location = New Point(0, 0)
        Label1.Location = SODEUtils.GetCenterWidth(Me, Label1)
        Label3.Location = SODEUtils.GetCenterWidth(Me, Label3)
        Label4.Location = SODEUtils.GetCenterWidth(Me, Label4)
    End Sub

    Private Sub SButton1_Click(sender As Object, e As EventArgs) Handles SButton1.Click
        Dim writer As New FileWriter("kernel.skc")
        writer.WriteLine("SipaaOS Kernel Configuration")
        writer.WriteLine("If this file is invalid or corrupted , SipaaOS can be breaked.")
        writer.WriteLine("-----------------------------------------------------------------------")
        writer.WriteLine("")
        writer.WriteLine("MAINFRM=SipaaOS.Boot")
        writer.WriteLine("SHOWCURSOR=false")
        writer.SaveFile()
        MsgBox.Show("SipaaOS Recovery", "The SipaaOS Kernel Configuration File is repaired! SipaaOS will reboot automatically.", MsgBoxType.Sucess)
        Me.Close()
    End Sub
End Class