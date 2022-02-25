
Public Class SipaaTabControl
    Inherits TabControl

    Public Enum Style
        Flat
        Line
    End Enum

    Private _TabStyle As Style
    Private _BtnBackColor As Color = Color.WhiteSmoke
    Private _BtnForeColor As Color = Color.Black
    Private _LineBackColor As Color = Color.Gainsboro
    Private _LineForeColor As Color = Color.LightSeaGreen

    Public Sub New()
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)

        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(140, 40)
        _TabStyle = Style.Line
    End Sub

    Public Property TabStyle As Style
        Get
            Return _TabStyle
        End Get
        Set(value As Style)
            _TabStyle = value
            Invalidate()
        End Set
    End Property
    Public Property ButtonBackColor As Color
        Get
            Return _BtnBackColor
        End Get
        Set(value As Color)
            _BtnBackColor = value
            Invalidate()
        End Set
    End Property
    Public Property ButtonForeColor As Color
        Get
            Return _BtnForeColor
        End Get
        Set(value As Color)
            _BtnForeColor = value
            Invalidate()
        End Set
    End Property
    Public Property LineBackColor As Color
        Get
            Return _LineBackColor
        End Get
        Set(value As Color)
            _LineBackColor = value
            Invalidate()
        End Set
    End Property
    Public Property LineForeColor As Color
        Get
            Return _LineForeColor
        End Get
        Set(value As Color)
            _LineForeColor = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using b As New Bitmap(Width, Height)
            Using g As Graphics = Graphics.FromImage(b)
                g.Clear(Parent.BackColor)

                For I As Integer = 0 To TabCount - 1
                    Dim tabrect As Rectangle = GetTabRect(I)

                    If I = SelectedIndex Then
                        Select Case TabStyle
                            Case Style.Flat
                                g.FillRectangle(New SolidBrush(ButtonBackColor), tabrect)
                                Exit Select
                            Case Style.Line
                                g.DrawLine(New Pen(LineBackColor, 3), 0, tabrect.Bottom, Me.Width, tabrect.Bottom)
                                g.FillRectangle(New SolidBrush(LineForeColor), New Rectangle(tabrect.Left, tabrect.Bottom - 1, ItemSize.Width, 3))
                                Exit Select
                        End Select

                        If ImageList IsNot Nothing Then
                            Try
                                If ImageList.Images(TabPages(I).ImageIndex) IsNot Nothing Then
                                    g.DrawImage(ImageList.Images(TabPages(I).ImageIndex), New Point(tabrect.Location.X + 8, tabrect.Location.Y + 6))
                                    g.DrawString("     " & TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                                Else
                                    g.DrawString(TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                                End If
                            Catch ex As Exception
                                g.DrawString(TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                            End Try
                        Else
                            g.DrawString(TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                        End If
                    Else
                        If ImageList IsNot Nothing Then
                            Try
                                If ImageList.Images(TabPages(I).ImageIndex) IsNot Nothing Then
                                    g.DrawImage(ImageList.Images(TabPages(I).ImageIndex), New Point(tabrect.Location.X + 8, tabrect.Location.Y + 6))
                                    g.DrawString("     " & TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                                Else
                                    g.DrawString(TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                                End If
                            Catch ex As Exception
                                g.DrawString(TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                            End Try
                        Else
                            g.DrawString(TabPages(I).Text, Font, New SolidBrush(Color.FromKnownColor(KnownColor.HotTrack)), tabrect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                        End If
                    End If
                Next
                MyBase.OnPaint(e)
                e.Graphics.DrawImage(b.Clone, 0, 0)
            End Using
        End Using
    End Sub
End Class
