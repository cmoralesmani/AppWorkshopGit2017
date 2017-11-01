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
            _Agenda = new List<Agenda>();
            LoadAgenda();
        }

        private void LoadAgenda()
        {
            _Agenda.Add(new Agenda
            {
                Nivel = 0,
                Descripcion = "Titulo 1",
                Hora = "8:00"
            });
            _Agenda.Add(new Agenda
            {
                Nivel = 1,
                Descripcion = "Titulo 2",
                Hora = "10:00"
            });
            _Agenda.Add(new Agenda
            {
                Nivel = 0,
                Descripcion = "Titulo 3",
                Hora = "12:00"
            });
        }

        public List<Agenda> _Agenda { get; set; }
    }
    public class Agenda
    {
            public int Nivel { get; set; }
        public Thickness Padding { get {
                return new Thickness(Nivel * 10, 0, 0, 0);
            } }
            public string Descripcion { get; set; }
        public string Hora { get; set; }
    }
}
