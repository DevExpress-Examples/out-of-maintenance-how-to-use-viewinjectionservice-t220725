using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXSample.Common;

namespace DXSample.ViewModel {
public class CustomersViewModel {
    public string Content { get; set; }

    protected CustomersViewModel() {
        Content = "A representation of CustomersViewModel.";
        ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () => {
            ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Customers);
        });
    }
    public static CustomersViewModel Create() {
        return ViewModelSource.Create(() => new CustomersViewModel());
    }
}
}
