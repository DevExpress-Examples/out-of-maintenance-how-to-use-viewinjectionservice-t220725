using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXSample.Common;
using System.Windows.Media.Imaging;

namespace DXSample.ViewModel {
    public class NavigationItemViewModel {
        
        public virtual string Title { get; set; }
        public virtual BitmapImage Image { get; set; }
        public virtual ModuleType ModuleType { get; set; }

        protected NavigationItemViewModel() {
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(this, () => {
                ViewInjectionManager.Default.Navigate(Regions.Main, ModuleType);
            });
        }
        public static NavigationItemViewModel Create(string title, BitmapImage image, ModuleType type) {
            var t = ViewModelSource.Create(() => new NavigationItemViewModel());
            t.Title = title;
            t.Image = image;
            t.ModuleType = type;
            return t;
        }
    }
}
