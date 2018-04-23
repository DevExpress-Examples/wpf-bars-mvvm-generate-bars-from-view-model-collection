using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Windows.Media;

namespace DXSample.ViewModels {

    [POCOViewModel]
    public class ButtonBarItemViewModel : BarItemViewModel {
        Action action;

        public ButtonBarItemViewModel(Action action) {
            Caption = "";
            this.action = action;
        }

        [Command]
        public void ExecuteAction() {
            if (action != null) {
                action();
            }
        }

        public virtual ImageSource LargeGlyph { get; set; }
        public virtual ImageSource SmallGlyph { get; set; }
    }
}