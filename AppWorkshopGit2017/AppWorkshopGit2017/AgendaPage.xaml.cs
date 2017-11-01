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
        public AgendaPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            AgendaViewModel agenda = new AgendaViewModel();
            ListViewAgenda.ItemsSource = agenda._Agenda;
        }

        private async void ListViewAgenda_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var element = e.SelectedItem as Item;
                if (!string.IsNullOrEmpty(element.Descripcion))
                    await DisplayAlert("Descripción", element.Descripcion, "Aceptar");
            }
        }
    }
}