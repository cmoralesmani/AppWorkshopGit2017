using DevAzt.FormsX.Storage.SQLite.LiteConnection;
using DevAzt.FormsX.Storage.SQLite.StandarDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppWorkshopGit2017
{
    public partial class App : Application
    {
        public static LocalDB DB { get; private set; }

        public App()
        {
            InitializeComponent();

            ConfigDatabase();
            
            MainPage = new AppWorkshopGit2017.MainPage();
        }

        private void ConfigDatabase()
        {
            Keys.DataBaseName = "info200code";

            App.DB = LocalDB.Instance;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
