Public Class SODEUtils
    Public Shared Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.Cyan


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)


    End Sub
    Public Shared Function GetCenter(frm As Form, ctrl As Control) As Point
        Return New Point(frm.Width / 2 - ctrl.Width / 2, frm.Height / 2 - ctrl.Height / 2)
    End Function

    Public Shared Function GetCenterWidth(frm As Form, ctrl As Control) As Point
        Return New Point(frm.Width / 2 - ctrl.Width / 2, ctrl.Location.Y)
    End Function

    Public Shared Function GetCenterHeight(frm As Form, ctrl As Control) As Point
        Return New Point(ctrl.Location.X, frm.Height / 2 - ctrl.Height / 2)
    End Function
End Class
