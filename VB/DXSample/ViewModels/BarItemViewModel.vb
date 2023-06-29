Imports DevExpress.Mvvm.DataAnnotations
Imports System

Namespace DXSample.ViewModels

    Public Class BarItemViewModel
        Inherits StaticBarItemViewModel

        Private action As Action(Of String)

        Public Sub New(ByVal action As Action(Of String), ByVal Optional caption As String = Nothing, ByVal Optional glyph As Uri = Nothing)
            Me.Caption = caption
            Me.action = action
            Me.Glyph = glyph
        End Sub

        <Command>
        Public Sub ExecuteAction(ByVal parameter As String)
            If action IsNot Nothing Then
                action(parameter)
            End If
        End Sub

        Public Property Glyph As Uri
            Get
                Return GetValue(Of Uri)()
            End Get

            Set(ByVal value As Uri)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
