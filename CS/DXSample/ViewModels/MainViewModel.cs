using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DXSample.Common;
using System;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    [POCOViewModel]
    public class MainViewModel {
        public MainViewModel() {
            Initalization();
        }

        #region Initalization
        private void Initalization() {
            Bars = new ObservableCollection<BarViewModel>();
            //Bars
            var mainMenuBar = ViewModelSource.Create(() => new BarViewModel() { BarType = BarType.MainMenu, Caption = "Main Menu" });
            var statusBar = ViewModelSource.Create(() => new BarViewModel() { BarType = BarType.StatusBar, Caption = "Status Bar" });
            //Items
            var newItem = ViewModelSource.Create(() => new ButtonBarItemViewModel(NewCommandExecuteFunc) { Caption = "New", LargeGlyph = DXImageHelper.GetDXImage("New_32x32.png"), SmallGlyph = DXImageHelper.GetDXImage("New_16x16.png") });
            var openItem = ViewModelSource.Create(() => new ButtonBarItemViewModel(OpenCommandExecuteFunc) { Caption = "Open", LargeGlyph = DXImageHelper.GetDXImage("Open_32x32.png"), SmallGlyph = DXImageHelper.GetDXImage("Open_16x16.png") });
            var helpItem = ViewModelSource.Create(() => new ButtonBarItemViewModel(HelpCommandExecuteFunc) { Caption = "Help" });
            var exitItem = ViewModelSource.Create(() => new ButtonBarItemViewModel(ExitCommandExecuteFunc) { Caption = "Exit" });
            var fileGroupItem = ViewModelSource.Create(() => new GroupBarItemViewModel() { Caption = "File", LargeGlyph = DXImageHelper.GetDXImage("File_32x32.png"), SmallGlyph = DXImageHelper.GetDXImage("File_16x16.png") });
            fileGroupItem.SubItems.Add(newItem);
            fileGroupItem.SubItems.Add(openItem);
            fileGroupItem.SubItems.Add(ViewModelSource.Create(() => new BarItemViewModelBase()));
            fileGroupItem.SubItems.Add(exitItem);
            var statusBarItem = ViewModelSource.Create(() => new BarItemViewModel() { Caption = DateTime.Now.ToShortDateString() });

            mainMenuBar.Items.Add(fileGroupItem);
            mainMenuBar.Items.Add(helpItem);
            statusBar.Items.Add(statusBarItem);
            Bars.Add(mainMenuBar);
            Bars.Add(statusBar);
        }
        #endregion

        public void ExitCommandExecuteFunc() {
            MessageBoxService.ShowMessage("Exit Command executed");
        }
        public void HelpCommandExecuteFunc() {
            MessageBoxService.ShowMessage("Help Command executed");
        }
        public void NewCommandExecuteFunc() {
            MessageBoxService.ShowMessage("New Command executed");
        }
        public void OpenCommandExecuteFunc() {
            MessageBoxService.ShowMessage("Open Command executed");
        }

        public virtual ObservableCollection<BarViewModel> Bars { get; set; }
        public IMessageBoxService MessageBoxService { get { return this.GetService<IMessageBoxService>(); } }
    }
}