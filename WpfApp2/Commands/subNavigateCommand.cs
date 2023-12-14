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
    public class subNavigateCommand : CommandBase
    {

        private readonly MainNavigationStore _navigation;
        private readonly modelViewBase _view;

        public subNavigateCommand(MainNavigationStore navigation, modelViewBase view)
        {
            _navigation = navigation;
            _view = view;
        }


        public override void Execute(object parameter)
        {
            _navigation.CurrentSubViewModel = _view;
        }
    }
}
