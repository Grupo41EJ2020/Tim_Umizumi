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
    public class RepositorioCurso_Tema_Video : ICurso_Tema_Video
    {
        public List<Curso_Tema_Video> obtenerCurso_Tema_Video()
        {
            DataTable dtCurso_Tema_Video = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Consultar_Todo", CommandType.StoredProcedure);
            List<Curso_Tema_Video> lstCurso_Tema_Video = new List<Curso_Tema_Video>();

            foreach (DataRow item in dtCurso_Tema_Video.Rows)
            {
                Curso_Tema_Video datosCurso_Tema_Video = new Curso_Tema_Video();

                datosCurso_Tema_Video.IdCTV = int.Parse(item["IdCTV"].ToString());
                datosCurso_Tema_Video.IdCT = int.Parse(item["IdCT"].ToString());
                datosCurso_Tema_Video.IdVideo = int.Parse(item["IdVIDEO"].ToString());

                lstCurso_Tema_Video.Add(datosCurso_Tema_Video);
            }
            return lstCurso_Tema_Video;
        }

        public Curso_Tema_Video obtenerCurso_Tema_Video(int IdCTV)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", IdCTV));

            DataTable dtCurso_Tema_Video = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Consultar_PorID", CommandType.StoredProcedure, parametros);

            Curso_Tema_Video miCurso_Tema_Video = new Curso_Tema_Video();

            if (dtCurso_Tema_Video.Rows.Count > 0)
            {
                miCurso_Tema_Video.IdCTV = int.Parse(dtCurso_Tema_Video.Rows[0]["idCTV"].ToString());
                miCurso_Tema_Video.IdCT = int.Parse(dtCurso_Tema_Video.Rows[0]["idCT"].ToString());
                miCurso_Tema_Video.IdVideo = int.Parse(dtCurso_Tema_Video.Rows[0]["idVideo"].ToString());
                return miCurso_Tema_Video;
            }
            else
            {
                return null;
            }
        }

        public void insertarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema_Video.IdCT));
            parametros.Add(new SqlParameter("@IdVideo", datosCurso_Tema_Video.IdVideo));

            BaseHelper.ejecutarSentencia("sp_Curso_Tema_Video_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarCurso_Tema_Video(int IdCTV)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", IdCTV));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Eliminar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_Video)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdCTV", datosCurso_Tema_Video.IdCTV));
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema_Video.IdCT));
            parametros.Add(new SqlParameter("@IdVideo", datosCurso_Tema_Video.IdVideo));

            BaseHelper.ejecutarSentencia("sp_Curso_Tema_Video_Actualizar", CommandType.StoredProcedure, parametros);
        }

        public List<Curso_Tema_Video> obtenerCursos_Tema_Video()
        {
            throw new NotImplementedException();
        }
    }
}