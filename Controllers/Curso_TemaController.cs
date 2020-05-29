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
    public class Curso_TemaController : Controller
    {
        RepositorioCurso_Tema reposCurso_Tema = new RepositorioCurso_Tema();

        public ActionResult Index()
        {
            return View(reposCurso_Tema.obtenerCursos_Temas());
        }

        public ActionResult Details(int id)
        {
            return View(reposCurso_Tema.obtenerCurso_Tema(id));
        }

        public ActionResult Delete(int id)
        {
            return View(reposCurso_Tema.obtenerCurso_Tema(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            reposCurso_Tema.eliminarCurso_Tema(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(reposCurso_Tema.obtenerCurso_Tema(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Curso_Tema datos)
        {
            datos.IdCT = id;
            reposCurso_Tema.insertarCurso_Tema(datos);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Curso_Tema datos)
        {
            reposCurso_Tema.insertarCurso_Tema(datos);
            return RedirectToAction("Index");

        
        }

    }
}
