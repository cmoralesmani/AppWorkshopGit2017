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
                Intent intent = new Intent(this, new NavigationPage( new MainTabbedPage()));
                intent.StartIntent();
            }
            else
            {
                DisplayAlert("Error","Escriba un email válido", "Aceptar");
            }
        }
    }
}
