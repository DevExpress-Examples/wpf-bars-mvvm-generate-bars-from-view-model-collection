Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels

    Public Class BarViewModel

        Public Sub New()
            Items = New ObservableCollection(Of BarItemViewModelBase)()
        End Sub

        Public Property BarType As BarType

        Public Property Caption As String

        Public Property Items As ObservableCollection(Of BarItemViewModelBase)
    End Class

    Public Enum BarType
        MainMenu
        StatusBar
    End Enum
End Namespace
