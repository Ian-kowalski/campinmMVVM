using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.MVVM.Camping.Commands;
using WPF.MVVM.Camping.Stores;
using WPF.MVVM.Camping.Views.subViews;

namespace WPF.MVVM.Camping.ViewModel
{
    internal class CampsitesMapViewModel:modelViewBase
    {
        private readonly MainNavigationStore _navigation;
        public modelViewBase CurrentSubViewModel => _navigation.CurrentSubViewModel;

        public ICommand subNavigateCommand { get; }

        public CampsitesMapViewModel(MainNavigationStore navigation)
        {
            _navigation = navigation;

            _navigation.CurrentSubViewModelChanged += OnCurrentViewModelChanged;
            subNavigateCommand = new subNavigateCommand(_navigation, new reservationInputViewModel(false ,_navigation));
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentSubViewModel));
        }

    }
}
