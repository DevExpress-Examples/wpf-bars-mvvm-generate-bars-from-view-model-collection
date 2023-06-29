using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
            Initalization();
        }
        public ObservableCollection<BarViewModel> Bars { get; set; }
        IMessageBoxService MessageBoxService { get { return GetService<IMessageBoxService>(); } }

        private void Initalization() {
            Bars = new ObservableCollection<BarViewModel>();

            //Bars

            var mainMenuBar = new BarViewModel() {
                BarType = BarType.MainMenu,
                Caption = "Main Menu"
            };
            var statusBar = new BarViewModel() {
                BarType = BarType.StatusBar,
                Caption = "Status Bar"
            };

            //Items

            var newItem = new BarItemViewModel(ExecuteCommandFunction, "New", new Uri("pack://application:,,,/Images/New.svg"));
            var openItem = new BarItemViewModel(ExecuteCommandFunction, "Open", new Uri("pack://application:,,,/Images/Open.svg"));
            var exitItem = new BarItemViewModel(ExecuteCommandFunction, "Exit", new Uri("pack://application:,,,/Images/Exit.svg"));
            var helpItem = new BarItemViewModel(ExecuteCommandFunction, "Help");
            var fileGroupItem = new GroupBarItemViewModel("File");

            fileGroupItem.SubItems.Add(newItem);
            fileGroupItem.SubItems.Add(openItem);
            fileGroupItem.SubItems.Add(new BarItemViewModelBase());
            fileGroupItem.SubItems.Add(exitItem);

            var staticBarItem = new StaticBarItemViewModel(DateTime.Now.ToShortDateString());

            mainMenuBar.Items.Add(fileGroupItem);
            mainMenuBar.Items.Add(helpItem);

            statusBar.Items.Add(staticBarItem);

            Bars.Add(mainMenuBar);
            Bars.Add(statusBar);
        }

        public void ExecuteCommandFunction(string parameter) {
            MessageBoxService.ShowMessage($"{parameter} Command executed");
        }
    }
}
