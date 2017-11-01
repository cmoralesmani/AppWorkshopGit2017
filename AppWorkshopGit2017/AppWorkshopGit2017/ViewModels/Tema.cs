using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWorkshopGit2017.ViewModels
{
    public class Tema
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaTemas
    {
        public List<Tema> _temas { get; set; }

        public ListaTemas()
        {
            _temas = new List<Tema>();
            LoadTemas();
        }
        private void LoadTemas()
        {
            _temas.Add(new Tema
            {
                Id = 1,
                Descripcion = "Sistema de control de versiones"
            });
            _temas.Add(new Tema
            {
                Id = 2,
                Descripcion = "Que es Git?"
            });
        }
    }
}
