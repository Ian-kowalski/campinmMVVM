using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.MVVM.Camping.Commands;
using WPF.MVVM.Camping.Stores;
using WPF.MVVM.Camping.Views;

namespace WPF.MVVM.Camping.ViewModel
{
    internal class MainViewModel : modelViewBase
    {
        private readonly MainNavigationStore _navigation;
        private MainNavigationStore navigation;

        public modelViewBase CurrentViewModel => _navigation.CurrentViewModel;


        public ICommand CampsitesControlCommand { get; }
        public ICommand MakeReservationCommand { get; }
        public ICommand EditReservation { get; }

        public MainViewModel(MainNavigationStore navigation)
        {
            _navigation = navigation;

            _navigation.CurrentViewModelChanged += OnCurrentViewModelChanged;

            CampsitesControlCommand = new NavigateCommand(_navigation, new CampsitesControlViewModel(_navigation));
            MakeReservationCommand = new NavigateCommand(_navigation, new makeReservationViewModel(_navigation));
            EditReservation = new NavigateCommand(_navigation, new editReservationViewModel(_navigation));
        }


        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
