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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.Properties.ContainsKey("email"))
            {
                string emailGuardado = Application.Current.Properties["email"] as string;
                if (!string.IsNullOrWhiteSpace(emailGuardado))
                {
                    EntryEmail.Text = emailGuardado;
                    //Enviar();
                }
            }
        }

        private void ButtonEnviar_Clicked(object sender, EventArgs e)
        {
            Enviar();
        }

        private async void Enviar()
        {
            string email = EntryEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                var respuesta = await DisplayAlert("Error", "No ha escrito un email válido", "Omitir", "Volver");
                if (!respuesta)
                    return;
            }

            // Persiste el dato del email en la aplicación
            if (Application.Current.Properties.ContainsKey("email"))
                Application.Current.Properties["email"] = email;
            else
                Application.Current.Properties.Add("email", email);

            Intent intent = new Intent(this, new NavigationPage(new MainTabbedPage()));
            intent.StartIntent();
        }
    }
}
