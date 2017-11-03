using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppWorkshopGit2017.Models
{
    public class Item
    {
        public string Titulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }
        public Thickness Padding
        {
            get
            {
                return new Thickness(Nivel * 10, 5, 0, 5);
            }
        }
    }
}
