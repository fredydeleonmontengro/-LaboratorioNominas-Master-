using capaDatos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace capaLogica
{
    public class logica
    {
        sentencias sn = new sentencias();

        public OdbcDataReader conceptos(string codigo, string nombre, string efecto)
        {
            return sn.Insertarconceptos(codigo,nombre,efecto);
        }
        public OdbcDataReader departamentos(string codigo, string nombre)
        {
            return sn.InsertarDepartamentos(codigo, nombre);
        }
        public OdbcDataReader empleados(string codigo, string nombre, string puesto, string departamento, string sueldo)
        {
            return sn.InsertarEmpleados(codigo, nombre, puesto, departamento, sueldo);
        }
        public OdbcDataReader puestos(string codigo, string nombre)
        {
            return sn.InsertarPuestos(codigo, nombre);
        }
    }
}
