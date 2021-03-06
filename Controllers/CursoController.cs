﻿using System;
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

        public ActionResult Create()
        {

            ViewData["lista"] = reposCurso.listaEmpleado();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Curso datos)
        {
            reposCurso.insertarCurso(datos);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            ViewData["lista"] = reposCurso.listaEmpleado();
            return View(reposCurso.obtenerCurso(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Curso datos)
        {
            datos.IdCurso = id;
            reposCurso.actualizarCurso(datos);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {           
            return View(reposCurso.obtenerCurso(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            reposCurso.eliminarCurso(id);
            return RedirectToAction("Index");
        }
    }
}

