using AppWorkshopGit2017.ViewModels;
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
	public partial class AgendaPage : ContentPage
	{
		public AgendaPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaTemas temas = new ListaTemas();
            ListTemas.ItemsSource = temas._temas;
            ListTemas.ItemSelected += ListTemas_ItemSelected;
        }

        private async void ListTemas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                var element = e.SelectedItem as Tema;
                await DisplayAlert("Listas", element.Descripcion,"Aceptar");
            }
        }
    }
}