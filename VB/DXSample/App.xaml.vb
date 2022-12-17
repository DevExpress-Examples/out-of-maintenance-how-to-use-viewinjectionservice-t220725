Imports DevExpress.Mvvm
Imports DXSample.Common
Imports DXSample.View
Imports DXSample.ViewModel
Imports System
Imports System.Windows
Imports System.Windows.Media.Imaging

Namespace DXSample

    Public Partial Class App
        Inherits Application

        Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
            InitModules()
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName()
        End Sub

        Private Sub InitModules()
            Call ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Customers, Function() NavigationItemViewModel.Create("Customers", New BitmapImage(New Uri("../Images/Customers.png", UriKind.RelativeOrAbsolute)), ModuleType.Customers), GetType(NavigationItemView))
            Call ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Sales, Function() NavigationItemViewModel.Create("Sales", New BitmapImage(New Uri("../Images/Sales.png", UriKind.RelativeOrAbsolute)), ModuleType.Sales), GetType(NavigationItemView))
            Call ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Products, Function() NavigationItemViewModel.Create("Products", New BitmapImage(New Uri("../Images/Products.png", UriKind.RelativeOrAbsolute)), ModuleType.Products), GetType(NavigationItemView))
            Call ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Customers, Function() CustomersViewModel.Create(), GetType(CustomersView))
            Call ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Sales, Function() SalesViewModel.Create(), GetType(SalesView))
            Call ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Products, Function() ProductsViewModel.Create(), GetType(ProductsView))
            ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Customers)
            Call ViewInjectionManager.Default.Navigate(Regions.Main, ModuleType.Customers)
        End Sub
    End Class
End Namespace
