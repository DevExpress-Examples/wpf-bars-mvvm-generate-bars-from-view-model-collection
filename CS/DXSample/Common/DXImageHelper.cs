using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;
using System.Windows.Media;

namespace DXSample.Common {
    public static class DXImageHelper {
        public static ImageSource GetDXImage(string dxImageName) {
            DXImageExtension extension = new DXImageExtension();
            extension.Image = new DXImageConverter().ConvertFromString(dxImageName) as DXImageInfo;
            return extension.ProvideValue(null) as ImageSource;
        }
    }
}
