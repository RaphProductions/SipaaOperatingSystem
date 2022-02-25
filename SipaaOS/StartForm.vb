Public Class StartForm
    Public Sub MainSub(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        mainModule.Main()
        Me.Close()
    End Sub
End Class