using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenderEqualizer.ViewModels
{
    public class MalePerspective5ViewModel : ViewModelBase
    {
        public MalePerspective5ViewModel(INavigationService navigation)
             : base(navigation)
        {

        }
        private DelegateCommand _nextCommand;
        public DelegateCommand NextCommand =>
            _nextCommand ?? (_nextCommand = new DelegateCommand(ExecuteNextCommand));

        async void ExecuteNextCommand()
        {
            await NavigationService.NavigateAsync("maleperspective");
        }
    }
}
