using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Models;
using MVCLaboratorio.Utilerias;


namespace MVCLaboratorio.Models
{
    public class RepositorioCurso:ICurso
    {
        public List<Curso> obtenerCursos()
        {
              DataTable dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_Consultar_Todo", CommandType.StoredProcedure);
            List<Curso> lstCurso = new List<Curso>();

            foreach (DataRow item in dtCurso.Rows)
            {
                Curso datosCurso = new Curso();

                datosCurso.IdCurso = int.Parse(item["IDCURSO"].ToString());
                datosCurso.Descripcion = item["DESCRIPCION"].ToString();
                datosCurso.IdEmpleado = int.Parse(item["IDEMPLEADO"].ToString());

                lstCurso.Add(datosCurso);
            }

            return lstCurso;
        }

        public Curso obtenerCurso(int idCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", idCurso));

            DataTable dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_Consultar_PorID", CommandType.StoredProcedure, parametros);

            Curso miCurso = new Curso();

            if (dtCurso.Rows.Count > 0)
            {
                miCurso.IdCurso = int.Parse(dtCurso.Rows[0]["IdCurso"].ToString());
                miCurso.Descripcion = dtCurso.Rows[0]["Descripcion"].ToString();
                miCurso.IdEmpleado = int.Parse(dtCurso.Rows[0]["IdEmpleado"].ToString());
                miCurso.NombreEmpleado = dtCurso.Rows[0]["Nombre"].ToString();
                return miCurso;
            }
            else
            {
                return null;
            }
        }

        public void insertarCurso(Curso datosCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));

            BaseHelper.ejecutarSentencia("sp_Curso_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarCurso(int idCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", idCurso));

            BaseHelper.ejecutarConsulta("sp_Curso_Eliminar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarCurso(Curso datosCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idcurso", datosCurso.IdCurso));
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));

            BaseHelper.ejecutarSentencia("sp_Curso_Actualizar", CommandType.StoredProcedure, parametros);
        }

        public List<SelectListItem> listaEmpleado() 
        {
            DataTable dtEmpleado = BaseHelper.ejecutarConsulta("sp_Curso_CargarEmpleados", CommandType.StoredProcedure);
            List<SelectListItem> listaEmpleados = new List<SelectListItem>();

            for (int i = 0; i < dtEmpleado.Rows.Count; i++)
            {
                listaEmpleados.Add(new SelectListItem { Text = dtEmpleado.Rows[i]["Nombre"].ToString(), Value = dtEmpleado.Rows[i]["IdEmpleado"].ToString() });
            }

            listaEmpleados.Insert(0, new SelectListItem { Text = "---SELECCIONE---", Value = "" });

            return listaEmpleados;
        }
    }
}