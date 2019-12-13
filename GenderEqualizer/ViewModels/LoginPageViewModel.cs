using GenderEqualizer.Models;
using Prism.Commands;
using Prism.Navigation;

namespace GenderEqualizer.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }
        public LoginPageViewModel(INavigationService navigationService)            
            : base(navigationService)
        {
            Title = "Main Page";
         
            var userClass = new User();
            User = userClass;
        }

        private DelegateCommand _continue;
        public DelegateCommand ContinueCommand =>
           _continue ?? (_continue = new DelegateCommand(ExecuteContinue));

        async void ExecuteContinue()
        {

            if(User.Gender.ToUpper() == "MALE")
            {
                await NavigationService.NavigateAsync("femaleperspective1");
            }
            
            if(User.Gender.ToUpper() == "FEMALE")
            {
                await NavigationService.NavigateAsync("malesperspective1");
            }
        }
    }
}

   
