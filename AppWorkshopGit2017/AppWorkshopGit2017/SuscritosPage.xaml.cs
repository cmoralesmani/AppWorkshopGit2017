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
    public partial class SuscritosPage : ContentPage
    {
        public SuscritosPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SwitchSave.OnChanged += SwitchSave_OnChanged;
        }

        private void SwitchSave_OnChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                var email = EntryEmail.Text;
                DisplayAlert("Mensaje", email, "Aceptar");
            }
        }
    }
}