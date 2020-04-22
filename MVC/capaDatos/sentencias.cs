using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
   public  class sentencias
    {
        conexion cn = new conexion();
        OdbcCommand comm;

        public OdbcDataReader Insertarconceptos(string codigo, string nombre, string efecto)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + codigo + ", '" + nombre + "' ,'" + efecto + "','1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader InsertarDepartamentos(string codigo, string nombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into departamento values(" + codigo + ", '" + nombre + "' ,'1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader InsertarEmpleados(string codigo, string nombre, string puesto, string departamento, string sueldo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into empleado values(" + codigo + ", '" + nombre + "' ,'" + puesto + "','" + departamento + "','" + sueldo + "','1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader InsertarPuestos(string codigo, string nombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into puesto values(" + codigo + ", '" + nombre + "' ,'1');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
