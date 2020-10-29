using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANAS3_SANTIAGOE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //habilitabdo la NAVEGACION ENTRE VENTANAS
            MainPage = new NavigationPage(new MainPage());
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
