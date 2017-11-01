using AppWorkshopGit2017.Models;
using AppWorkshopGit2017.Models.RestClient;
using AppWorkshopGit2017.Repositories;
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

        private async void ListViewAgenda_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var element = e.Item as ItemAgenda;
                if (!string.IsNullOrEmpty(element.Descripcion))
                    await DisplayAlert("Descripción", element.Descripcion, "Aceptar");
            }

                // Quita la selección
                ((ListView)sender).SelectedItem = null;
        }
    }
}