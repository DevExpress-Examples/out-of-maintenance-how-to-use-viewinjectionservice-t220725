Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DXSample.Common

Namespace DXSample.ViewModel

    Public Class ProductsViewModel

        Public Overridable Property Content As String

        Protected Sub New()
            Content = "A representation of ProductsViewModel."
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(Me, Sub() ViewInjectionManager.Default.Navigate(Navigation, ModuleType.Products))
        End Sub

        Public Shared Function Create() As ProductsViewModel
            Return ViewModelSource.Create(Function() New ProductsViewModel())
        End Function
    End Class
End Namespace
