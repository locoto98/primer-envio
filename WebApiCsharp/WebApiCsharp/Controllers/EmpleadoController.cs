using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCsharp.Models;

namespace WebApiCsharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        List<Empleado> empleados = new List<Empleado>()
        {
            new Empleado{ id = 1, nombre = "christian" , username = "chris", passwd = "hola123" },
            new Empleado{ id = 2, nombre = "julio" , username = "hulk", passwd = "jul123" },
            new Empleado{ id = 3, nombre = "maria" , username = "mari", passwd = "mari123" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.empleados);
        }

        [HttpGet("login")]
        public IActionResult GetUserByUsername(UserModel userModel)
        {
            if( this.empleados.Count < 0)
            {
                return BadRequest();
            }
            var user = this.empleados.FirstOrDefault(u => u.username == userModel.username && u.passwd == userModel.passwd);
            if( user == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
