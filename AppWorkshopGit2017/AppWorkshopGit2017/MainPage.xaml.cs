using AppWorkshopGit2017.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppWorkshopGit2017
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            if (!string.IsNullOrEmpty(email))
            {
                var homeViewModel = new HomeViewModel();
                homeViewModel.Titulo = "Titulo de prueba";
                this.Navigation.PushModalAsync(new HomePage(homeViewModel));
            }
            else
            {
                DisplayAlert("Error","Escriba un email válido", "Aceptar");
            }
        }
    }
}
