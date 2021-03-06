﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Models;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioVideo:IVideo
    {
        public List<Video> obtenerVideos()
        {
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideo = new List<Video>();
            foreach (DataRow item in dtVideo.Rows)
            {
                Video datosVideo = new Video();

                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideo.Add(datosVideo);
            }
            return lstVideo;
        }

        public Video obtenerVideo(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", idVideo));

            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);

            Video miVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return miVideo;
            }
            else
            {   
                return null;
            }
        }

        public void insertarVideo(Video datosVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosVideo.Nombre));
            parametros.Add(new SqlParameter("@Url", datosVideo.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datosVideo.FechaPublicacion));
            BaseHelper.ejecutarSentencia("sp_Video_Inserta", CommandType.StoredProcedure, parametros);
        }

        public void eliminarVideo(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", idVideo));

            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarVideo(Video datosVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", datosVideo.IdVideo));
            parametros.Add(new SqlParameter("@Nombre", datosVideo.Nombre));
            parametros.Add(new SqlParameter("@Url", datosVideo.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datosVideo.FechaPublicacion));

            BaseHelper.ejecutarSentencia("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
        }
    }
}