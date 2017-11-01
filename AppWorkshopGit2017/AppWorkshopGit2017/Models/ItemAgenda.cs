using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppWorkshopGit2017.Models
{
    public class ItemAgenda : Item
    {
        public TimeSpan Hora { get; set; }
        public string HoraString
        {
            get
            {
                DateTime time = DateTime.Today.Add(Hora);
                return time.ToString("hh:mm tt");
            }
        }
    }
}
