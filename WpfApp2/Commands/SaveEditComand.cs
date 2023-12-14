using Reservoom.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.Camping.ViewModel;

namespace WPF.MVVM.Camping.Commands
{
    internal class SaveEditComand : CommandBase
    {
        private reservationInputViewModel _reservationInputViewModel;

        public SaveEditComand(reservationInputViewModel reservationInputViewModel)
        {
            _reservationInputViewModel = reservationInputViewModel;
            _reservationInputViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }


        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_reservationInputViewModel.FirstName) && base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(reservationInputViewModel.FirstName))
            {
                OnCanExecutedChanged();
            }
        }

    }
}
