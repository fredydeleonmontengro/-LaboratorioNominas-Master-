using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class sentencias
    {
        conexion cn = new conexion();
        OdbcCommand comm;

        public OdbcDataReader Insertarconceptos(string codigo, string nombre, string efecto, string valor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + codigo + ", '" + nombre + "' ,'" + efecto + "','" + valor + "');";
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

        public OdbcDataReader insertnominae(string codigo, string fechainicial, string fechafinal)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into nominae values(" + codigo + ", '" + fechainicial + "' , '" + fechafinal + "');";
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
        public OdbcDataReader insertnominad(string codigo, string codempleado, string codconcepto, string valor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into nominad values(" + codigo + ", '" + codempleado + "' , '" + codconcepto + "', '" + valor + "');";
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
        public OdbcDataReader empleados()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM empleado;";
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
        public OdbcDataReader conceptos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM concepto;";
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
