using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenderEqualizer.ViewModels
{
    public class femaleperspective3ViewModel : ViewModelBase
    {
        public femaleperspective3ViewModel(INavigationService navigationService)
           : base(navigationService)
        {

        }
        private DelegateCommand _herpov;
        public DelegateCommand HerPov =>
            _herpov ?? (_herpov = new DelegateCommand(ExecuteHerPov));

        async void ExecuteHerPov()
        {
            await NavigationService.NavigateAsync("femaleperspective4");
        }
    }
}
