
using AppWorkshopGit2017.ORM;
using DevAzt.FormsX.Storage.SQLite.LiteConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAzt.FormsX.Storage.SQLite.StandarDB
{
    public class LocalDB : DataBase
    {
        public Table<Info> Info { get; set; }

        public LocalDB(string databasePath, bool storeDateTimeAsTicks = true) : base(databasePath, storeDateTimeAsTicks)
        {
            Info = DBSet<Info>();
        }

        public static LocalDB Instance
        {
            get
            {
                var service = Xamarin.Forms.DependencyService.Get<IDataBase>();
                if (service != null)
                    return service.GetDataBase();

                throw new Exception("No es posible obtener el servicio");
            }
        }
    }
}