Imports System
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels

    Public Class GroupBarItemViewModel
        Inherits BarItemViewModel

        Public Sub New(ByVal Optional caption As String = Nothing, ByVal Optional glyph As Uri = Nothing)
            MyBase.New(Nothing, caption, glyph)
            SubItems = New ObservableCollection(Of BarItemViewModelBase)()
        End Sub

        Public ReadOnly Property SubItems As ObservableCollection(Of BarItemViewModelBase)
    End Class
End Namespace
