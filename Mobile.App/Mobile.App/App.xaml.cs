using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mobile.App.Services;
using Mobile.App.Views;
using Mobile.App.ViewModels.Base;
using Mobile.App.Helpers;
using System.Threading.Tasks;

namespace Mobile.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitApp();
            Check();
        }

        private void InitApp()
        {
            ViewModelLocator.RegisterDependencies(false);
        }

        private async void Check()
        {
            await ConnectivityHelper.CheckConnectivityAsync();
            //await ConnectivityHelper.StartConnectivityListener();
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override async void OnStart()
        {
            base.OnStart();
            await InitNavigation();
        }
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
