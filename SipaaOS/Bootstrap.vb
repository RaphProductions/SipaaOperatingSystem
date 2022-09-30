Imports System.IO

Public Class Bootstrap
    Private Sub Bootstrap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args As String() = Environment.GetCommandLineArgs()
        For Each arg In args
            If arg.Contains("loggedFromLoginUI") Then
                If arg.Contains("true") Then
                    Console.WriteLine("Logged from siloginui.exe")
                    Desktop.logged = True
                    Exit For
                End If
            End If
        Next
        ' Load Configuration
        If Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Configuration\") And File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Configuration\SODE.cfg") And File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Configuration\USER.cfg") Then
            Dim sodeconfig As String() = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Configuration\SODE.cfg")
            Dim userconfig As String() = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Configuration\USER.cfg")
            If File.Exists(sodeconfig(2).Replace("BackgroundFile=", "")) Then
                Desktop.BackgroundImage = Image.FromFile(sodeconfig(2).Replace("BackgroundFile=", ""))
            Else
                Desktop.BackgroundImage = My.Resources.sipaabg
            End If
            If sodeconfig(3).Replace("Theme=", "") = "Light" Or sodeconfig(3).Replace("Theme=", "") = "Dark" Then
                My.Settings.Theme = sodeconfig(3)
            Else
                My.Settings.Theme = "Dark"
            End If
            My.Settings.Username = userconfig(2).Replace("Username=", "")
            If userconfig(3).Replace("Password=", "") = "Nothing" Then
                My.Settings.Password = ""
            Else
                My.Settings.Password = userconfig(3).Replace("Password=", "")
            End If
        Else
            My.Settings.Reset()
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Configuration\")
            Settings.SaveSettingsToFile(AppDomain.CurrentDomain.BaseDirectory + "Configuration\SODE.cfg", AppDomain.CurrentDomain.BaseDirectory + "Configuration\USER.cfg")
        End If
        If Desktop.logged = False Then
            Desktop.HideSODE()
            MsgBox.Show("SipaaSODE", "Im sorry but you need to login for use this version of SODE.", MsgBoxType.SError)
            Me.Close()
        End If
    End Sub
End Class