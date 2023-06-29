Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DXSample.Common
Imports System.Collections.ObjectModel

Namespace DXSample.ViewModels

    <POCOViewModel>
    Public Class MainViewModel

        Public Sub New()
            Initalization()
        End Sub

'#Region "Initalization"
        Private Sub Initalization()
            Bars = New ObservableCollection(Of BarViewModel)()
            'Bars
            Dim mainMenuBar = ViewModelSource.Create(Function() New BarViewModel() With {.BarType = BarType.MainMenu, .Caption = "Main Menu"})
            Dim statusBar = ViewModelSource.Create(Function() New BarViewModel() With {.BarType = BarType.StatusBar, .Caption = "Status Bar"})
            'Items
            Dim newItem = ViewModelSource.Create(Function() New ButtonBarItemViewModel(AddressOf NewCommandExecuteFunc) With {.Caption = "New", .LargeGlyph = GetDXImage("New_32x32.png"), .SmallGlyph = GetDXImage("New_16x16.png")})
            Dim openItem = ViewModelSource.Create(Function() New ButtonBarItemViewModel(AddressOf OpenCommandExecuteFunc) With {.Caption = "Open", .LargeGlyph = GetDXImage("Open_32x32.png"), .SmallGlyph = GetDXImage("Open_16x16.png")})
            Dim helpItem = ViewModelSource.Create(Function() New ButtonBarItemViewModel(AddressOf HelpCommandExecuteFunc) With {.Caption = "Help"})
            Dim exitItem = ViewModelSource.Create(Function() New ButtonBarItemViewModel(AddressOf ExitCommandExecuteFunc) With {.Caption = "Exit"})
            Dim fileGroupItem = ViewModelSource.Create(Function() New GroupBarItemViewModel() With {.Caption = "File", .LargeGlyph = GetDXImage("File_32x32.png"), .SmallGlyph = GetDXImage("File_16x16.png")})
            fileGroupItem.SubItems.Add(newItem)
            fileGroupItem.SubItems.Add(openItem)
            fileGroupItem.SubItems.Add(ViewModelSource.Create(Function() New BarItemViewModelBase()))
            fileGroupItem.SubItems.Add(exitItem)
            Dim statusBarItem = ViewModelSource.Create(Function() New BarItemViewModel() With {.Caption = Date.Now.ToShortDateString()})
            mainMenuBar.Items.Add(fileGroupItem)
            mainMenuBar.Items.Add(helpItem)
            statusBar.Items.Add(statusBarItem)
            Bars.Add(mainMenuBar)
            Bars.Add(statusBar)
        End Sub

'#End Region
        Public Sub ExitCommandExecuteFunc()
            MessageBoxService.ShowMessage("Exit Command executed")
        End Sub

        Public Sub HelpCommandExecuteFunc()
            MessageBoxService.ShowMessage("Help Command executed")
        End Sub

        Public Sub NewCommandExecuteFunc()
            MessageBoxService.ShowMessage("New Command executed")
        End Sub

        Public Sub OpenCommandExecuteFunc()
            MessageBoxService.ShowMessage("Open Command executed")
        End Sub

        Public Overridable Property Bars As ObservableCollection(Of BarViewModel)

        Public ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property
    End Class
End Namespace
