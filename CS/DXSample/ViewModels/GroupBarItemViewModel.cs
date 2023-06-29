using System;
using System.Collections.ObjectModel;

namespace DXSample.ViewModels {
    public class GroupBarItemViewModel : BarItemViewModel {
        public GroupBarItemViewModel(string caption = null, Uri glyph = null) : base(null, caption, glyph) {
            SubItems = new ObservableCollection<BarItemViewModelBase>();
        }
        public ObservableCollection<BarItemViewModelBase> SubItems { get; }
    }
}
