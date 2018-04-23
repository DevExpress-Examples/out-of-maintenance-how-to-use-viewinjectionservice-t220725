using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXSample.Common;

namespace DXSample.ViewModel {
    public class SalesViewModel {
        public string Content { get; set; }
        public SalesViewModel() {
            Content = "A representation of SalesViewModel.";
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () => {
                ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Sales);
            });
        }
        public static SalesViewModel Create() {
            return ViewModelSource.Create(() => new SalesViewModel());
        }
    }
}
