Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DXSample.Common

Namespace DXSample.ViewModel

    Public Class SalesViewModel

        Public Property Content As String

        Public Sub New()
            Content = "A representation of SalesViewModel."
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(Me, Sub() ViewInjectionManager.Default.Navigate(Navigation, ModuleType.Sales))
        End Sub

        Public Shared Function Create() As SalesViewModel
            Return ViewModelSource.Create(Function() New SalesViewModel())
        End Function
    End Class
End Namespace
