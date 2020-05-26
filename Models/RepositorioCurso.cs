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
            throw new NotImplementedException();
        }

        public void eliminarCurso(int idCurso)
        {
            throw new NotImplementedException();
        }

        public void actualizarCurso(Curso datosCurso)
        {
            throw new NotImplementedException();
        }
    }
}