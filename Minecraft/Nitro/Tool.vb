Imports System.Runtime.InteropServices

Public Class Tool
#Region "DLL"
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
    End Function

    <DllImport("gdi32.dll", EntryPoint:="DeleteObject")>
    Private Shared Function DeleteObject(hObject As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
#End Region
    Public Shared Sub SmoothBorder(form As Form, Round As Integer)
        Dim ptr As IntPtr = CreateRoundRectRgn(0, 0, form.Width, form.Height, Round, Round)
        form.Region = Region.FromHrgn(ptr)
        DeleteObject(ptr)
    End Sub
    Public Shared Sub SmoothBorder(form As Control, Round As Integer)
        Dim ptr As IntPtr = CreateRoundRectRgn(0, 0, form.Width, form.Height, Round, Round)
        form.Region = Region.FromHrgn(ptr)
        DeleteObject(ptr)
    End Sub
    Public Shared Sub MoveForm(handle As IntPtr)
        ReleaseCapture()
        SendMessage(handle, &HA1, &H2, 0)
    End Sub
End Class