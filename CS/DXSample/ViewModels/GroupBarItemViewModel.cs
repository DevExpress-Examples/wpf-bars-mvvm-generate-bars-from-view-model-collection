using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {

    [POCOViewModel]
    public class GroupBarItemViewModel : ButtonBarItemViewModel {
        public GroupBarItemViewModel() : base(null) {
            SubItems = new ObservableCollection<BarItemViewModelBase>();
        }

        public virtual ObservableCollection<BarItemViewModelBase> SubItems { get; set; }
    }
}