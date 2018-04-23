using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXSample.ViewModel {
    public class MainViewModel {
        protected MainViewModel() { }
        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }
    }
}
