using AppWorkshopGit2017.Models;
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
            LoadAgenda();
        }

        private void LoadAgenda()
        {
            _Agenda.Add(new ItemAgenda
            {
                Id="1",
                Nombre = "Presentación",
                Descripcion = "",
                Hora = new TimeSpan(8, 0, 0),
                Nivel = 0
            });
            _Agenda.Add(new ItemAgenda
            {
                Id = "2",
                Nombre = "Iniciando con Git",
                Descripcion = "",
                Hora = new TimeSpan(8, 30, 0),
                Nivel = 0
            });
            _Agenda.Add(new ItemAgenda
            {
                Id = "2.1",
                Nombre = "Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones",
                Descripcion = "",
                Hora = new TimeSpan(8, 30, 0),
                Nivel = 1
            });
            _Agenda.Add(new ItemAgenda
            {
                Id = "2.2",
                Nombre = "Comandos básicos",
                Descripcion = "",
                Hora = new TimeSpan(8, 45, 0),
                Nivel = 1
            });
            _Agenda.Add(new ItemAgenda
            {
                Id = "2.2.1",
                Nombre = "git init",
                Descripcion = "",
                Hora = new TimeSpan(8, 45, 0),
                Nivel = 2
            });
            _Agenda.Add(new ItemAgenda
            {
                Id = "3",
                Nombre = "Receso",
                Descripcion = "Regrigerio patrocinado por 200Code",
                Hora = new TimeSpan(12, 0, 0),
                Nivel = 0
            });
            _Agenda.Add(new ItemAgenda
            {
                Id = "4",
                Nombre = "Fin",
                Descripcion = "",
                Hora = new TimeSpan(16, 0, 0),
                Nivel = 0
            });
        }
    }
    
}
