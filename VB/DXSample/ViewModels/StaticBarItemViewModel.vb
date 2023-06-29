Namespace DXSample.ViewModels

    Public Class StaticBarItemViewModel
        Inherits BarItemViewModelBase

        Public Sub New(ByVal Optional caption As String = Nothing)
            Me.Caption = caption
        End Sub

        Public Property Caption As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
