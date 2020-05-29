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
    public class TemaController : Controller
    {

        RepositorioTema reposTema = new RepositorioTema();
        public ActionResult Index()
        {
            return View(reposTema.obtenerTemas());
        }
        public ActionResult Details(int id)
        {
            return View(reposTema.obtenerTema(id));
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tema datos)
        {
            reposTema.insertarTema(datos);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(reposTema.obtenerTema(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            reposTema.eliminarTema(id);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(reposTema.obtenerTema(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Tema datos)
        {
            datos.IdTema = id;
            reposTema.actualizarTema(datos);
            return RedirectToAction("Index");
        }
    }
}
