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
        public AgendaViewModel()
        {
            _Agenda = new List<Item>();
            LoadAgenda();
        }

        private void LoadAgenda()
        {
            _Agenda.Add(new Item
            {
                Id="1",
                Nombre = "Presentación",
                Descripcion = "",
                Hora = new TimeSpan(8, 0, 0),
                Nivel = 0
            });
            _Agenda.Add(new Item
            {
                Id = "2",
                Nombre = "Iniciando con Git",
                Descripcion = "",
                Hora = new TimeSpan(8, 30, 0),
                Nivel = 0
            });
            _Agenda.Add(new Item
            {
                Id = "2.1",
                Nombre = "Control de versiones",
                Descripcion = "",
                Hora = new TimeSpan(8, 30, 0),
                Nivel = 1
            });
            _Agenda.Add(new Item
            {
                Id = "2.2",
                Nombre = "Comandos básicos",
                Descripcion = "",
                Hora = new TimeSpan(8, 45, 0),
                Nivel = 1
            });
            _Agenda.Add(new Item
            {
                Id = "2.2.1",
                Nombre = "git init",
                Descripcion = "",
                Hora = new TimeSpan(8, 45, 0),
                Nivel = 2
            });
            _Agenda.Add(new Item
            {
                Id = "3",
                Nombre = "Receso",
                Descripcion = "Regrigerio patrocinado por 200Code",
                Hora = new TimeSpan(12, 0, 0),
                Nivel = 0
            });
            _Agenda.Add(new Item
            {
                Id = "4",
                Nombre = "Fin",
                Descripcion = "",
                Hora = new TimeSpan(16, 0, 0),
                Nivel = 0
            });
        }

        public List<Item> _Agenda { get; set; }
    }
    public class Item
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan Hora { get; set; }
        public int Nivel { get; set; }
        public Thickness Padding
        {
            get
            {
                return new Thickness(Nivel * 10, 0, 0, 0);
            }
        }
    }
}
