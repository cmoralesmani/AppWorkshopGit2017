using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWorkshopGit2017.ORM
{
    public class Info
    {
        [PrimaryKey, AutoIncrement]
        public int IdInfo { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan Hora { get; set; }
        public int Nivel { get; set; }
    }
}
