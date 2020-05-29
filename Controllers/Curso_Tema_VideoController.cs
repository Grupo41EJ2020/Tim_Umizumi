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
    public class Curso_Tema_VideoController : Controller
    {
        //
        // GET: /Curso_Tema_Video/

        RepositorioCurso_Tema_Video reposCurso_Tema_Video = new RepositorioCurso_Tema_Video();

        public ActionResult Index()
        {
            return View(reposCurso_Tema_Video.obtenerCurso_Tema_Video());
        }
        public ActionResult Details(int id)
        {
            return View(reposCurso_Tema_Video.obtenerCurso_Tema_Video(id));
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Curso_Tema_Video datos)
        {
            reposCurso_Tema_Video.insertarCurso_Tema_Video(datos);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(reposCurso_Tema_Video.obtenerCurso_Tema_Video(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Curso_Tema_Video datos)
        {
            datos.IdCTV = id;
            reposCurso_Tema_Video.actualizarCurso_Tema_Video(datos);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(reposCurso_Tema_Video.obtenerCurso_Tema_Video(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            reposCurso_Tema_Video.eliminarCurso_Tema_Video(id);
            return RedirectToAction("Index");
        }
    }
}
