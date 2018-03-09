using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEmpleadosRoute.Models
{
    public class ModeloEmpleados
    {
        HOSPITALEntities contexto;
        public ModeloEmpleados()
        {
            contexto = new HOSPITALEntities();
        }

        public List<EMP> GetEmpleados()
        {
            var consulta = from datos in contexto.EMP
                           select datos;
            return consulta.ToList();
        }
        public EMP BuscarEmpleado(int empno)
        {
            return contexto.EMP.Find(empno);
        }
        public List<EMP> BuscarEmpleadosSalario(int salario)
        {
            var consulta = from datos in contexto.EMP
                           where datos.SALARIO >= salario
                           select datos;
            if(consulta.Count()== 0)
            {
                return null;
            }
            else
            {
                return consulta.ToList();
            }
        }
    }
}