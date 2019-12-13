using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenderEqualizer.ViewModels
{
    public class FemalePerspective5ViewModel : ViewModelBase
    {
        
        private DelegateCommand _nextCommand;
        public DelegateCommand NextCommand =>
            _nextCommand ?? (_nextCommand = new DelegateCommand(ExecuteNextCommand));

        async void ExecuteNextCommand()
        {
            await NavigationService.NavigateAsync("femaleperspective2xaml");
        }
        public FemalePerspective5ViewModel(INavigationService navigationService)
           : base(navigationService)
        {

        }
    }
}


