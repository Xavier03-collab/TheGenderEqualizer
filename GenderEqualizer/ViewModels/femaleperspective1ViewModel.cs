using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenderEqualizer.ViewModels
{
    public class femaleperspective1ViewModel : ViewModelBase
    {
        public femaleperspective1ViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
        private DelegateCommand _nextCommand;
        public DelegateCommand NextCommand =>
            _nextCommand ?? (_nextCommand = new DelegateCommand(ExecuteNextCommand));

        async void ExecuteNextCommand()
        {
            await NavigationService.NavigateAsync("femaleperspective2xaml");
        }
    }
}
