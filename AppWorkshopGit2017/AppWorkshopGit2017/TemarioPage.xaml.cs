using AppWorkshopGit2017.Models;
using AppWorkshopGit2017.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppWorkshopGit2017
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemarioPage : ContentPage
    {
        public ObservableCollection<ItemTemario> Items { get; set; }

        public TemarioPage()
        {
            InitializeComponent();

            TemarioViewModel temario = new TemarioViewModel();
            Items = new ObservableCollection<ItemTemario>(temario._Temario);

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //TemarioViewModel temario = new TemarioViewModel();
            //ListViewTemario.ItemsSource = temario._Temario;
        }

        private async void ListViewTemario_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var element = e.Item as ItemTemario;
                if (!string.IsNullOrEmpty(element.Descripcion))
                    await DisplayAlert("Descripción", element.Descripcion, "Aceptar");
            }

            // Quita la selección
            ((ListView)sender).SelectedItem = null;
        }
    }
}