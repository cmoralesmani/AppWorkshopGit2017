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
            LoadTemario();
        }

        private void LoadTemario()
        {
            _Temario.Add(new ItemTemario
            {
                Id = "1",
                Nombre = "Introducción a Control de Versiones",
                Nivel = 0
            });
            _Temario.Add(new ItemTemario
            {
                Id = "2",
                Nombre = "Instalación y configuración",
                Nivel = 0
            });
            _Temario.Add(new ItemTemario
            {
                Id = "3",
                Nombre = "Ayuda de GIT",
                Nivel = 0
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4",
                Nombre = "Flujo de trabajo",
                Nivel = 0
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4.1",
                Nombre = "git init",
                Nivel = 1
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4.2",
                Nombre = "git add|rm|status",
                Nivel = 1
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4.3",
                Nombre = "git commit",
                Nivel = 1
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4.4",
                Nombre = "git tag",
                Nivel = 1
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4.5",
                Nombre = "git log",
                Nivel = 1
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4.6",
                Nombre = "git diff",
                Nivel = 1
            });
            _Temario.Add(new ItemTemario
            {
                Id = "4.7",
                Nombre = "git reset",
                Nivel = 1
            });
        }
    }
}
