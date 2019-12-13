using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenderEqualizer.ViewModels
{
    public class femaleperspective2xamlViewModel : ViewModelBase
    {
        public femaleperspective2xamlViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
        private DelegateCommand _feministSide;
        public DelegateCommand FeministSide =>
            _feministSide ?? (_feministSide = new DelegateCommand(ExecutefeministSide));

        async void ExecutefeministSide()
        {
            await NavigationService.NavigateAsync("femaleperspective3");
        }
    }
}
