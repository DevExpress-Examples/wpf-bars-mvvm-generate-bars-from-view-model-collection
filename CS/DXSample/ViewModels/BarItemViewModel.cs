using DevExpress.Mvvm.DataAnnotations;
using System;

namespace DXSample.ViewModels {
    public class BarItemViewModel : StaticBarItemViewModel {

        Action<string> action;

        public BarItemViewModel(Action<string> action, string caption = null, Uri glyph = null) {
            this.Caption = caption;
            this.action = action;
            this.Glyph = glyph;
        }

        [Command]
        public void ExecuteAction(string parameter) {
            if (action != null) {
                action(parameter);
            }
        }

        public Uri Glyph {
            get { return this.GetValue<Uri>(); ; }
            set { this.SetValue(value); }
        }

    }
}
