using AppWorkshopGit2017.Models;
using AppWorkshopGit2017.Models.RestClient;
using AppWorkshopGit2017.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppWorkshopGit2017.ViewModels
{
    public class AgendaViewModel
    {
        public List<ItemAgenda> _Agenda { get; set; }

        public AgendaViewModel()
        {
            _Agenda = new List<ItemAgenda>();

            var info = App.DB.Info.ToList().Where(i => i.Tipo == "AGEN");
            foreach(var i in info)
            {
                _Agenda.Add(new ItemAgenda
                {
                    Titulo = i.Titulo,
                    Nombre = i.Nombre,
                    Descripcion = i.Descripcion,
                    Nivel = i.Nivel,
                    Hora = i.Hora
                });
            }
        }
    }

}
