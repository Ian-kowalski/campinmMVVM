using Reservoom.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVM.Camping.Stores;
using WPF.MVVM.Camping.ViewModel;

namespace WPF.MVVM.Camping.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly MainNavigationStore _navigation;
        private readonly modelViewBase _view;

        public NavigateCommand(MainNavigationStore navigation, modelViewBase view)
        {
            _navigation = navigation;
            _view = view;
        }


        public override void Execute(object parameter)
        {
            _navigation.CurrentViewModel = _view;
        }
    }
}
