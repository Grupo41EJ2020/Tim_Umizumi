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
        //
        // GET: /Curso/

        public ActionResult Index()
        {
            DataTable dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_Consultar_Todo", CommandType.StoredProcedure);
            List<Curso> lstCurso = new List<Curso>();

            foreach (DataRow item in dtCurso.Rows)
            {
                Curso datosCurso = new Curso();

                datosCurso.IdCurso = int.Parse(item["IDCURSO"].ToString());
                datosCurso.Descripcion = item["DESCRIPCION"].ToString();
                datosCurso.NombreEmpleado = item["NOMBRE"].ToString();

                lstCurso.Add(datosCurso);
            }
            return View(lstCurso);
        }

        //
        // GET: /Curso/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Curso/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Curso/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Curso/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Curso/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Curso/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Curso/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

