Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.Windows.Media

Namespace DXSample.ViewModels

    <POCOViewModel>
    Public Class ButtonBarItemViewModel
        Inherits BarItemViewModel

        Private action As Action

        Public Sub New(ByVal action As Action)
            Caption = ""
            Me.action = action
        End Sub

        <Command>
        Public Sub ExecuteAction()
            If action IsNot Nothing Then
                action()
            End If
        End Sub

        Public Overridable Property LargeGlyph As ImageSource

        Public Overridable Property SmallGlyph As ImageSource
    End Class
End Namespace
