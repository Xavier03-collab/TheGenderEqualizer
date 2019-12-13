using GenderEqualizer.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenderEqualizer.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        private DelegateCommand _loginPage;
        public DelegateCommand LoginPageCommand =>
           _loginPage ?? (_loginPage = new DelegateCommand(ExecuteLoginPage));

        async void ExecuteLoginPage()
        {
            await NavigationService.NavigateAsync("LoginPage");
        }
    }
}
