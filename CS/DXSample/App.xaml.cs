using DevExpress.Mvvm;
using DXSample.Common;
using DXSample.View;
using DXSample.ViewModel;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace DXSample {
    public partial class App : Application {
        private void Application_Startup(object sender, StartupEventArgs e) {
            InitModules();
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();
        }
        private void InitModules() {
            ViewInjectionManager.Default.Inject(
                Regions.Navigation, 
                ModuleType.Customers, 
                () => NavigationItemViewModel.Create("Customers", new BitmapImage(new Uri(@"../Images/Customers.png", UriKind.RelativeOrAbsolute)), ModuleType.Customers), 
                typeof(NavigationItemView)
            );
            ViewInjectionManager.Default.Inject(
                Regions.Navigation, 
                ModuleType.Sales, 
                () => NavigationItemViewModel.Create("Sales", new BitmapImage(new Uri(@"../Images/Sales.png", UriKind.RelativeOrAbsolute)), ModuleType.Sales), 
                typeof(NavigationItemView)
            );
            ViewInjectionManager.Default.Inject(
                Regions.Navigation, 
                ModuleType.Products, 
                () => NavigationItemViewModel.Create("Products", new BitmapImage(new Uri(@"../Images/Products.png", UriKind.RelativeOrAbsolute)), ModuleType.Products), 
                typeof(NavigationItemView)
            );
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Customers, () => CustomersViewModel.Create(), typeof(CustomersView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Sales, () => SalesViewModel.Create(), typeof(SalesView));
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Products, () => ProductsViewModel.Create(), typeof(ProductsView));

            ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Customers);
            ViewInjectionManager.Default.Navigate(Regions.Main, ModuleType.Customers);
                       
        }
    }

}
