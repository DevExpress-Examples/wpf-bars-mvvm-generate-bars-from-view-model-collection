Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Sub New()
            Initalization()
        End Sub

        Public Property Bars As ObservableCollection(Of BarViewModel)

        Private ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property

        Private Sub Initalization()
            Bars = New ObservableCollection(Of BarViewModel)()
            'Bars
            Dim mainMenuBar = New BarViewModel() With {.BarType = BarType.MainMenu, .Caption = "Main Menu"}
            Dim statusBar = New BarViewModel() With {.BarType = BarType.StatusBar, .Caption = "Status Bar"}
            'Items
            Dim newItem = New BarItemViewModel(AddressOf ExecuteCommandFunction, "New", New Uri("pack://application:,,,/Images/New.svg"))
            Dim openItem = New BarItemViewModel(AddressOf ExecuteCommandFunction, "Open", New Uri("pack://application:,,,/Images/Open.svg"))
            Dim exitItem = New BarItemViewModel(AddressOf ExecuteCommandFunction, "Exit", New Uri("pack://application:,,,/Images/Exit.svg"))
            Dim helpItem = New BarItemViewModel(AddressOf ExecuteCommandFunction, "Help")
            Dim fileGroupItem = New GroupBarItemViewModel("File")
            fileGroupItem.SubItems.Add(newItem)
            fileGroupItem.SubItems.Add(openItem)
            fileGroupItem.SubItems.Add(New BarItemViewModelBase())
            fileGroupItem.SubItems.Add(exitItem)
            Dim staticBarItem = New StaticBarItemViewModel(Date.Now.ToShortDateString())
            mainMenuBar.Items.Add(fileGroupItem)
            mainMenuBar.Items.Add(helpItem)
            statusBar.Items.Add(staticBarItem)
            Bars.Add(mainMenuBar)
            Bars.Add(statusBar)
        End Sub

        Public Sub ExecuteCommandFunction(ByVal parameter As String)
            MessageBoxService.ShowMessage($"{parameter} Command executed")
        End Sub
    End Class
End Namespace
