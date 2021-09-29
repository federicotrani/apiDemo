using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly List<Persona> personas = new List<Persona>();

        public PersonaController()
        {
            personas.Add(new Persona(){
                Id = 1,
                Nombre = "Luis Garcia",
                Email = "luis@garcia.com",
                Domicilio = "San Luis 336",
                Telefono = "2954558877",
                Foto = "",
                Activo = true
            });

            personas.Add(new Persona(){
                Id = 2,
                Nombre = "Marta Perez",
                Email = "marta@garcia.com",
                Domicilio = "Santa Fe 398",
                Telefono = "2954887712",
                Foto = "",
                Activo = true
            });
        }

        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get(){
            return Ok(personas);
        }
    }
}