Imports System.IO
Public Class FileWriter
    Shared writer As StreamWriter
    Public Sub New(filePath As String)
        writer = New StreamWriter(AppDomain.CurrentDomain.BaseDirectory + filePath)
    End Sub

    Public Sub WriteLine(line As String)
        writer.WriteLine(line)
    End Sub

    Public Sub SaveFile()
        writer.Close()
    End Sub
End Class
