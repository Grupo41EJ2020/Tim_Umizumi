using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Models;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioEmpleado:IEmpleado
    {
        public List<Empleado> obtenerEmpleados()
        {
            DataTable dtEmpleado = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarTodo", CommandType.StoredProcedure);

            List<Empleado> lstEmpleado = new List<Empleado>();

            foreach (DataRow item in dtEmpleado.Rows)
            {
                Empleado datosEmpleado = new Empleado();

                datosEmpleado.IdEmpleado = int.Parse(item["IdEmpleado"].ToString());
                datosEmpleado.Nombre = item["Nombre"].ToString();
                datosEmpleado.Direccion = item["Direccion"].ToString();

                lstEmpleado.Add(datosEmpleado);
            }
            return lstEmpleado;
        }

        public Empleado obtenerEmpleado(int idEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", idEmpleado));

            DataTable dtEmpleado = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Empleado miEmpleado = new Empleado();

            if (dtEmpleado.Rows.Count > 0)
            {
                miEmpleado.IdEmpleado = int.Parse(dtEmpleado.Rows[0]["IdEmpleado"].ToString());
                miEmpleado.Nombre = dtEmpleado.Rows[0]["Nombre"].ToString();
                miEmpleado.Direccion = dtEmpleado.Rows[0]["Direccion"].ToString();
                return miEmpleado;
            }
            else
            {
                return null;
            }
        }

        public void insertarEmpleado(Empleado datosEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosEmpleado.Nombre));
            parametros.Add(new SqlParameter("@Direccion", datosEmpleado.Direccion));

            BaseHelper.ejecutarSentencia("sp_Empleado_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarEmpleado(int idEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", idEmpleado));

            BaseHelper.ejecutarConsulta("sp_Empleado_Eliminar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarEmpleado(Empleado datosEmpleado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", datosEmpleado.IdEmpleado));
            parametros.Add(new SqlParameter("@Nombre", datosEmpleado.Nombre));
            parametros.Add(new SqlParameter("@Direccion", datosEmpleado.Direccion));

            BaseHelper.ejecutarSentencia("sp_Empleado_Actualizar", CommandType.StoredProcedure, parametros);
        }
    }
}