Imports DXSample.ViewModels
Imports System.Windows
Imports System.Windows.Controls

Namespace DXSample.Common
    Public Class BarTemplateSelector
        Inherits DataTemplateSelector

        Public Property MainMenuTemplate() As DataTemplate
        Public Property StatusBarTemplate() As DataTemplate
        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            If item Is Nothing Then
                Return Nothing
            End If
            Dim vm = DirectCast(item, BarViewModel)
            Select Case vm.BarType
                Case BarType.MainMenu
                    Return MainMenuTemplate
                Case BarType.StatusBar
                    Return StatusBarTemplate
                Case Else
                    Return Nothing
            End Select
        End Function
    End Class
End Namespace
