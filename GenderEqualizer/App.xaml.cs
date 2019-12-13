using Prism;
using Prism.Ioc;
using GenderEqualizer.ViewModels;
using GenderEqualizer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GenderEqualizer
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<malesperspective1, MalePerspective1ViewModel>();
            containerRegistry.RegisterForNavigation<maleperspective2, MalePerspective2ViewModel>();
            containerRegistry.RegisterForNavigation<maleperspective3, MalePerspective3ViewModel>();
            containerRegistry.RegisterForNavigation<maleperspective4, MalePerspective4ViewModel>();
            containerRegistry.RegisterForNavigation<maleperspective5, MalePerspective5ViewModel>();
            containerRegistry.RegisterForNavigation<femaleperspective1, femaleperspective1ViewModel>();
            containerRegistry.RegisterForNavigation<femaleperspective2xaml, femaleperspective2xamlViewModel>();
            containerRegistry.RegisterForNavigation<femaleperspective3, femaleperspective3ViewModel>();
            containerRegistry.RegisterForNavigation<femaleperspective4, FemalePerspective4ViewModel>();
            containerRegistry.RegisterForNavigation<femaleperspective5, FemalePerspective5ViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        }
    }
}
