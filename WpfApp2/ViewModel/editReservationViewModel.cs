using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.Camping.Stores;

namespace WPF.MVVM.Camping.ViewModel
{
    internal class editReservationViewModel : modelViewBase
    {
        public modelViewBase editReservationListView { get; }
        public modelViewBase reservationInputView  { get; }

        public editReservationViewModel(MainNavigationStore navigation)
        {
            editReservationListView = new editReservationListViewModel();
            reservationInputView = new reservationInputViewModel(true, navigation);
        }
    }
}
