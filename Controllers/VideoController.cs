using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        RepositorioVideo reposVideo = new RepositorioVideo();

        public ActionResult Index()
        {
            return View(reposVideo.obtenerVideos());
        }
        public ActionResult Details(int id) 
        {
            return View(reposVideo.obtenerVideo(id));
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Video datos)
        {
            reposVideo.insertarVideo(datos);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(reposVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            reposVideo.eliminarVideo(id);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(reposVideo.obtenerVideo(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Video datos)
        {
            datos.IdVideo= id;
            reposVideo.actualizarVideo(datos);
            return RedirectToAction("Index");
        }
    }
}
