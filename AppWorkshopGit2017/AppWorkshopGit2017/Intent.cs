using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppWorkshopGit2017
{
    public class Intent
    {
        public Page _startPage { get; set; }
        public Page _endPage { get; set; }
        public Dictionary<string, object> DataObject { get; set; }
        public Dictionary<string, string> DataString { get; set; }

        public Intent(Page startPage, Page endPage)
        {
            _startPage = startPage;
            _endPage = endPage;
            DataObject = new Dictionary<string, object>();
            DataString = new Dictionary<string, string>();
        }

        public void PutObject(string key, object obj)
        {
            if (DataString.ContainsKey(key))
            {
                throw new ArgumentException("La llave ya existe");
            }
            DataObject.Add(key, obj);
        }
        public void PutString(string key, object value)
        {
            if (DataString.ContainsKey(key))
            {
                throw new ArgumentException("La llave ya existe");
            }
            DataObject.Add(key, value);
        }

        public object GetString(string key)
        {
            if (DataString.ContainsKey(key))
            {
                return DataString[key];
            }
            throw new ArgumentException("La llave no existe");
        }

        public object GetObject<T>(string key)
        {
            if (DataObject.ContainsKey(key))
            {
                return (T)DataObject[key];
            }
            throw new ArgumentException("La llave no existe");
        }

        public void StartIntent()
        {
            Navigation.Intent = this;
            _startPage.Navigation.PushModalAsync(_endPage,true);
        }
        public class Navigation
        {
            public static Intent Intent { get; set; }
        }
    }
}
