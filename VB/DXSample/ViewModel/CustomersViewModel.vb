Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DXSample.Common

Namespace DXSample.ViewModel
Public Class CustomersViewModel
    Public Property Content() As String

    Protected Sub New()
        Content = "A representation of CustomersViewModel."
        ViewInjectionManager.Default.RegisterNavigatedEventHandler(Me, Sub() ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Customers))
    End Sub
    Public Shared Function Create() As CustomersViewModel
        Return ViewModelSource.Create(Function() New CustomersViewModel())
    End Function
End Class
End Namespace
