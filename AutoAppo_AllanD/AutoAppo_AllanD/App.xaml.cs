using AutoAppo_AllanD.Services;
using AutoAppo_AllanD.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoAppo_AllanD
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //definimos la pagina de inicio
            MainPage = new NavigationPage(new AppoLoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
