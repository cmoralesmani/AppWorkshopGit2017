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
    public partial class FeedbackPage : ContentPage
    {
        List<string> Puntaje;

        public FeedbackPage()
        {
            InitializeComponent();
            InitApp();
        }

        private void InitApp()
        {
            Puntaje = new List<string>();
            Puntaje.Add("Malo");
            Puntaje.Add("Regular");
            Puntaje.Add("Bueno");
            Puntaje.Add("Muy bueno");

            foreach(var puntaje in Puntaje)
            {
                PickerPuntaje.Items.Add(puntaje);
            }
        }

        private void ButtonEnviar_Clicked(object sender, EventArgs e)
        {

        }
    }
}