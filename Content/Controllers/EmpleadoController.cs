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
    public class EmpleadoController : Controller
    {
        RepositorioEmpleado reposEmpleado = new RepositorioEmpleado();

        public ActionResult Index()
        {
            return View(reposEmpleado.obtenerEmpleados());
        }

        public ActionResult Details(int id)
        {
            return View(reposEmpleado.obtenerEmpleado(id));
        }

        public ActionResult Delete(int id)
        {
            return View(reposEmpleado.obtenerEmpleado(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection frm)
        {
            reposEmpleado.eliminarEmpleado(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(reposEmpleado.obtenerEmpleado(id));
        } 

        [HttpPost]
        public ActionResult Edit(int id, Empleado datos)
        {
            datos.IdEmpleado = id;
            reposEmpleado.actualizarEmpleado(datos);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Empleado datos)
        {
            reposEmpleado.insertarEmpleado(datos);
            return RedirectToAction("Index");
        }
    }
}
