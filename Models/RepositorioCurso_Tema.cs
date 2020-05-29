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
    public class RepositorioCurso_Tema : ICurso_Tema
    {
        public List<Curso_Tema> obtenerCursos_Temas()
        {
            DataTable dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Consultar_Todo", CommandType.StoredProcedure);

            List<Curso_Tema> lstCurso_Tema = new List<Curso_Tema>();

            foreach (DataRow item in dtCurso_Tema.Rows)
            {
                Curso_Tema datosCurso_Tema = new Curso_Tema();

                datosCurso_Tema.IdCT = int.Parse(item["IdCT"].ToString());
                datosCurso_Tema.IdCurso = int.Parse(item["IdCurso"].ToString());
                datosCurso_Tema.IdTema = int.Parse(item["IdTema"].ToString());

                lstCurso_Tema.Add(datosCurso_Tema);
            }

            return lstCurso_Tema;
        }

        public Curso_Tema obtenerCurso_Tema(int idCT)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", idCT));

            DataTable dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Consultar_PorID", CommandType.StoredProcedure, parametros);

            Curso_Tema miCurso_Tema = new Curso_Tema();

            if (dtCurso_Tema.Rows.Count > 0)
            {
                miCurso_Tema.IdCT = int.Parse(dtCurso_Tema.Rows[0]["IdCT"].ToString());
                miCurso_Tema.IdCurso = int.Parse(dtCurso_Tema.Rows[0]["IdCurso"].ToString());
                miCurso_Tema.IdTema = int.Parse(dtCurso_Tema.Rows[0]["IdTema"].ToString());
                return miCurso_Tema;
            }
            else
            {
                return null;
            }
        }

        public void insertarCurso_Tema(Curso_Tema datosCurso_Tema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", datosCurso_Tema.IdCurso));
            parametros.Add(new SqlParameter("@IdTema", datosCurso_Tema.IdTema));

            BaseHelper.ejecutarSentencia("sp_Curso_Tema_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarCurso_Tema(int idCT)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", idCT));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Eliminar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarCurso_Tema(Curso_Tema datosCurso_Tema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema.IdCT));
            parametros.Add(new SqlParameter("@IdCurso", datosCurso_Tema.IdCurso));
            parametros.Add(new SqlParameter("@IdTema", datosCurso_Tema.IdTema));

            BaseHelper.ejecutarSentencia("sp_Curso_Tema_Actualizar", CommandType.StoredProcedure, parametros);
        }

        List<Curso> ICurso_Tema.obtenerCursos_Temas()
        {
            throw new NotImplementedException();
        }
    }
}