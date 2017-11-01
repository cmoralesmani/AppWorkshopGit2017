using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API200Code.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }
    }
}
