Imports CefSharp.WinForms
Imports CefSharp

Public Class SedgeWebBrowser
    Dim address As String
    Friend WithEvents browser As ChromiumWebBrowser
    Private Sub SedgeWebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        browser = New ChromiumWebBrowser("google.com") With {.Dock = DockStyle.Fill}
        MetroPanel2.Controls.Add(browser)
        Timer1.Start()
    End Sub

    Private Sub browser_AddressChanged(sender As Object, e As AddressChangedEventArgs) Handles browser.AddressChanged
        Try
            address = e.Address
        Catch ex As Exception
            PSOD.Show()
            Desktop.Close()
        End Try
    End Sub

    Private Sub browser_TitleChanged(sender As Object, e As TitleChangedEventArgs) Handles browser.TitleChanged
        Try
            SedgeTabHandler.ChangeSelectedTabText(e.Title)
        Catch ex As Exception
            PSOD.Show()
            Desktop.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MetroTextBox1.Text = address
    End Sub
End Class