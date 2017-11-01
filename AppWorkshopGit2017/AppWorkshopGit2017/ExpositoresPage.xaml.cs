using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWorkshopGit2017
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpositoresPage : ContentPage
    {
        public ExpositoresPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ButtonGuardar.Clicked += ButtonGuardar_Clicked;

            if (Application.Current.Properties.ContainsKey("nombre"))
            {
                EntryNombre.Text = Application.Current.Properties["nombre"] as string;
            }
            if (Application.Current.Properties.ContainsKey("edad"))
            {
                EntryEdad.Text = Application.Current.Properties["edad"] as string;
            }
        }

        private async void ButtonGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre= EntryNombre.Text;
            string edad = EntryEdad.Text;

            Application.Current.Properties["nombre"] = nombre;
            Application.Current.Properties["edad"] = edad;
            await Application.Current.SavePropertiesAsync();
        }
    }
}