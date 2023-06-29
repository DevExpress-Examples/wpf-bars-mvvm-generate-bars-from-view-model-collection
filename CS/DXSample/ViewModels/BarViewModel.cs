using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    public class BarViewModel {
        public BarViewModel() {
            Items = new ObservableCollection<BarItemViewModelBase>();
        }
        public BarType BarType { get; set; }
        public string Caption { get; set; }
        public ObservableCollection<BarItemViewModelBase> Items { get; set; }
    }
    public enum BarType { MainMenu, StatusBar };
}
