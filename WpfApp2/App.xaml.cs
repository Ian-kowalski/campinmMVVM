using System.Configuration;
using System.Data;
using System.Windows;
using WPF.MVVM.Camping;
using WPF.MVVM.Camping.Stores;
using WPF.MVVM.Camping.ViewModel;
using WPF.MVVM.Camping.Views;
using WPF.MVVM.Camping.Views.subViews;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly MainNavigationStore navigation;
        public App()
        {
            navigation = new MainNavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            navigation.CurrentViewModel = new CampsitesControlViewModel(navigation);
            navigation.CurrentSubViewModel = new CampsitesMapViewModel(navigation);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigation)

            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
