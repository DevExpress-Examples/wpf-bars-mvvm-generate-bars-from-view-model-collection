using DXSample.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DXSample.Common {
    public class BarTemplateSelector : DataTemplateSelector {
        public DataTemplate MainMenuTemplate { get; set; }
        public DataTemplate StatusBarTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            if (item == null) return null;
            var vm = (BarViewModel)item;
            switch (vm.BarType) {
                case BarType.MainMenu :
                    return MainMenuTemplate;
                case BarType.StatusBar:
                    return StatusBarTemplate;
                default:
                    return null;
            }
        }
    }
}
