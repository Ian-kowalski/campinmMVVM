using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.Camping.Stores;
using WPF.MVVM.Camping.Views.subViews;

namespace WPF.MVVM.Camping.ViewModel
{
    public class makeReservationViewModel : modelViewBase
    {
        private readonly MainNavigationStore _NavigationStore;
        public modelViewBase CurendSubView =>  _NavigationStore.CurrentSubViewModel;

        public makeReservationViewModel(MainNavigationStore NavigationStore)
        {

            _NavigationStore = NavigationStore;


            _NavigationStore.CurrentSubViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurendSubView));
        }
    }
}
