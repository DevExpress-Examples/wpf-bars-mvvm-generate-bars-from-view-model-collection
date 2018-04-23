Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels

    <POCOViewModel> _
    Public Class GroupBarItemViewModel
        Inherits ButtonBarItemViewModel

        Public Sub New()
            MyBase.New(Nothing)
            SubItems = New ObservableCollection(Of BarItemViewModelBase)()
        End Sub

        Public Overridable Property SubItems() As ObservableCollection(Of BarItemViewModelBase)
    End Class
End Namespace