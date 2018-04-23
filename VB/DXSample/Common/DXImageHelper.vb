Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports System.Windows.Media

Namespace DXSample.Common
    Public NotInheritable Class DXImageHelper

        Private Sub New()
        End Sub

        Public Shared Function GetDXImage(ByVal dxImageName As String) As ImageSource
            Dim extension As New DXImageExtension()
            extension.Image = TryCast((New DXImageConverter()).ConvertFromString(dxImageName), DXImageInfo)
            Return TryCast(extension.ProvideValue(Nothing), ImageSource)
        End Function
    End Class
End Namespace
