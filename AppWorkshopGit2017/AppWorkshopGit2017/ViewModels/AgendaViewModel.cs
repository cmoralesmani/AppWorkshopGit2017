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
            Device.BeginInvokeOnMainThread(() =>
            {
                RestClient cliente = new RestClient();
                var result = cliente.Get<RootObject>("http://localhost:58300/api/values");
                if (result != null)
                {
                    _Agenda.Add(new ItemAgenda
                    {
                    });
                }
            });
        }
    }
    
}
