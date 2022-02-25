Imports System.IO

Module mainModule
    Function Main() As Integer
        Dim list As New List(Of Form)
        list.Add(About)
        list.Add(Boot)
        list.Add(ColorPick)
        list.Add(Desktop)
        list.Add(FileExplorer)
        list.Add(Login)
        list.Add(MsgBox)
        list.Add(Notepad)
        list.Add(Paint)
        list.Add(PSOD)
        list.Add(SedgeTabHandler)
        list.Add(Settings)
        Console.WriteLine("Sipaa Boot Loader is finding the kernel configuration")
        If File.Exists(AppDomain.CurrentDomain.BaseDirectory + "kernel.skc") = False Then
            PSOD.Show()
        Else
            'Code for show the Boot form
            Dim kernelcfg As String() = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "kernel.skc")
            Dim frmname, showCursor As String
            frmname = kernelcfg(4)
            frmname = frmname.Replace("MAINFRM=SipaaOS.", "")
            showCursor = kernelcfg(5)
            showCursor = showCursor.Replace("SHOWCURSOR=", "")
            For Each frm As Form In list
                If frmname = frm.Name Then
                    frm.Show()
                End If
            Next
            If showCursor = "true" Then
                Cursor.Show()
            End If
            Console.WriteLine("SipaaBootManager : Invalid form in kernel.skc , line 5")
            Return 0
            End If
    End Function
End Module