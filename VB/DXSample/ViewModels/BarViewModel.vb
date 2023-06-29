Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels

    <POCOViewModel>
    Public Class BarViewModel

        Public Sub New()
            Items = New ObservableCollection(Of BarItemViewModelBase)()
        End Sub

        Public Overridable Property BarType As BarType

        Public Overridable Property Caption As String

        Public Overridable Property Items As ObservableCollection(Of BarItemViewModelBase)
    End Class

    Public Enum BarType
        MainMenu
        StatusBar
    End Enum
End Namespace
