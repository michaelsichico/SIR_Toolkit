﻿Public Class DBPanel
    Inherits Panel

    Public Sub New()

        Me.DoubleBuffered = True

        SetStyle(ControlStyles.AllPaintingInWmPaint Or _
        ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

        UpdateStyles()
    End Sub
End Class
