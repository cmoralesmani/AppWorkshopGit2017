using AppWorkshopGit2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWorkshopGit2017.ViewModels
{
    public class TemarioViewModel
    {
        public List<ItemTemario> _Temario { get; set; }

        public TemarioViewModel()
        {
            _Temario = new List<ItemTemario>();

            var info = App.DB.Info.ToList().Where(i => i.Tipo == "TEMA");
            foreach (var i in info)
            {
                _Temario.Add(new ItemTemario
                {
                    Titulo = i.Titulo,
                    Nombre = i.Nombre,
                    Descripcion = i.Descripcion,
                    Nivel = i.Nivel
                });
            }
        }
    }
}
