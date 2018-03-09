using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEmpleadosRoute.Models;

namespace WebApiEmpleadosRoute.Controllers
{
    public class EmpleadosController : ApiController
    {
        ModeloEmpleados modelo;
        public EmpleadosController()
        {
            modelo = new ModeloEmpleados();
        }

        //get /api/Empleados
        public List<EMP> GetEmpleados() //lo llamamos como queramos pero empezando por Get
        {
            return modelo.GetEmpleados();
        }
        //get /api/Empleados/{id}
        public EMP GetEmpleado(int id)
        {
            return modelo.BuscarEmpleado(id);
        }

        //GET /api/EmpleadosSalario/{salario}
        [HttpGet] 
        [Route("api/EmpleadosSalario/{salario}")]
        public List<EMP> BuscarEmpleadosSalario(int salario)
        {
            return modelo.BuscarEmpleadosSalario(salario);

        }

    }
}
