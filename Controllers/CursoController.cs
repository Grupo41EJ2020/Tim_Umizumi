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
    public class CursoController : Controller
    {
        RepositorioCurso reposCurso = new RepositorioCurso();

        public ActionResult Index()
        {
            return View(reposCurso.obtenerCursos());
        }

        public ActionResult Details(int id)
        {
            return View(reposCurso.obtenerCurso(id));
        }

    }
}

