namespace DXSample.ViewModels {
    public class StaticBarItemViewModel : BarItemViewModelBase {
        public StaticBarItemViewModel(string caption = null) {
            this.Caption = caption;
        }
        public string Caption {
            get { return this.GetValue<string>(); ; }
            set { this.SetValue(value); }
        }

    }
}
