using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXSample.Common;

namespace DXSample.ViewModel {
    public class ProductsViewModel {
        public virtual string Content { get; set; }
        protected ProductsViewModel() {
            Content = "A representation of ProductsViewModel.";
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () => {
                ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Products);
            });
        }
        public static ProductsViewModel Create() {
            return ViewModelSource.Create(() => new ProductsViewModel());
        }
    }
}
