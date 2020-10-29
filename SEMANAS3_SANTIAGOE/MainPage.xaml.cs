using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SEMANAS3_SANTIAGOE
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private async void btnVentana_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user.Equals("estudiante2020") && pass.Equals("uisrael2020"))
            {
                await Navigation.PushAsync(new vista2(user, pass));
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }

        }
    }
}
