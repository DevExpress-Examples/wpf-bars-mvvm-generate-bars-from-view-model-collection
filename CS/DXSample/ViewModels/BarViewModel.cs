using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {

    [POCOViewModel]
    public class BarViewModel {
        public BarViewModel() {
            Items = new ObservableCollection<BarItemViewModelBase>();
        }

        public virtual BarType BarType { get; set; }
        public virtual string Caption { get; set; }
        public virtual ObservableCollection<BarItemViewModelBase> Items { get; set; }
    }
    public enum BarType { MainMenu, StatusBar };
}