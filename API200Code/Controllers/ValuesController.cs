using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API200Code.Models;

namespace API200Code.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return LoadAgenda();
        }
        private List<Item> LoadAgenda()
        {
            List<Item> _Agenda = new List<Item>();
            _Agenda.Add(new Item
            {
                Id = "1",
                Nombre = "Presentación",
                Descripcion = "",
                Nivel = 0
            });
            _Agenda.Add(new Item
            {
                Id = "2",
                Nombre = "Iniciando con Git",
                Descripcion = "",
                Nivel = 0
            });
            _Agenda.Add(new Item
            {
                Id = "2.1",
                Nombre = "Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones Control de versiones",
                Descripcion = "",
                Nivel = 1
            });
            _Agenda.Add(new Item
            {
                Id = "2.2",
                Nombre = "Comandos básicos",
                Descripcion = "",
                Nivel = 1
            });
            _Agenda.Add(new Item
            {
                Id = "2.2.1",
                Nombre = "git init",
                Descripcion = "",
                Nivel = 2
            });
            _Agenda.Add(new Item
            {
                Id = "3",
                Nombre = "Receso",
                Descripcion = "Regrigerio patrocinado por 200Code",
                Nivel = 0
            });
            _Agenda.Add(new Item
            {
                Id = "4",
                Nombre = "Fin",
                Descripcion = "",
                Nivel = 0
            });

            return _Agenda;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
