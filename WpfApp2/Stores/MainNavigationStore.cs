using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.Camping.ViewModel;

namespace WPF.MVVM.Camping.Stores
{
    public class MainNavigationStore
    {

        private modelViewBase _currentViewModel;

        public modelViewBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {

                _currentViewModel = value;
                OnCurrentViewModelChanged();

            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged;



        private modelViewBase _currentSubViewModel;

        public modelViewBase CurrentSubViewModel
        {
            get => _currentSubViewModel;
            set
            {

                _currentSubViewModel = value;
                OnCurrentSubViewModelChanged();

            }
        }

        private void OnCurrentSubViewModelChanged()
        {
            CurrentSubViewModelChanged?.Invoke();
        }

        public event Action CurrentSubViewModelChanged;

    }
}
