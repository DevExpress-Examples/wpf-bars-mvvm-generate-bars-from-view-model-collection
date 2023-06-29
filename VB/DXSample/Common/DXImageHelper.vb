Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports System.Windows.Media

Namespace DXSample.Common

    Public Module DXImageHelper

        Public Function GetDXImage(ByVal dxImageName As String) As ImageSource
            Dim extension As DXImageExtension = New DXImageExtension()
            extension.Image = TryCast(New DXImageConverter().ConvertFromString(dxImageName), DXImageInfo)
            Return TryCast(extension.ProvideValue(Nothing), ImageSource)
        End Function
    End Module
End Namespace
