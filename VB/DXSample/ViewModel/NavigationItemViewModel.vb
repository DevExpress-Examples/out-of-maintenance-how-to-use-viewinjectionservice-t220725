Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DXSample.Common
Imports System.Windows.Media.Imaging

Namespace DXSample.ViewModel
    Public Class NavigationItemViewModel

        Public Overridable Property Title() As String
        Public Overridable Property Image() As BitmapImage
        Public Overridable Property ModuleType() As ModuleType

        Protected Sub New()
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(Me, Sub() ViewInjectionManager.Default.Navigate(Regions.Main, ModuleType))
        End Sub
        Public Shared Function Create(ByVal title As String, ByVal image As BitmapImage, ByVal type As ModuleType) As NavigationItemViewModel
            Dim t = ViewModelSource.Create(Function() New NavigationItemViewModel())
            t.Title = title
            t.Image = image
            t.ModuleType = type
            Return t
        End Function
    End Class
End Namespace
