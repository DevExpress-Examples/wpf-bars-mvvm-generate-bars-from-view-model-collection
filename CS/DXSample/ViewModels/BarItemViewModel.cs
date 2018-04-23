using DevExpress.Mvvm.DataAnnotations;

namespace DXSample.ViewModels {

    [POCOViewModel]
    public class BarItemViewModel : BarItemViewModelBase {
        public BarItemViewModel() { }

        public virtual string Caption { get; set; }
    }
}