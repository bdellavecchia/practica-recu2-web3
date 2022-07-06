using BD.ModeloEF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using xdDellaVecchia_recuPractica.Servicios.Interfaces;


/*Agregar un proyecto ASP.Net Core donde solamente exista un controller llamado ObrasDeArteController,
y el mismo permita crear nuevas Obras de Arte*/


namespace xdDellaVecchia_recuPractica.Controllers
{
    public class ObrasDeArteController : Controller
    {
        IObraDeArteServicio _obraDeArteServicio;

        public ObrasDeArteController(IObraDeArteServicio obraDeArteServicio)
        {
            _obraDeArteServicio = obraDeArteServicio;
        }

        // GET: ObrasDeArteController
        public ActionResult Index()
        {
            ViewBag.ObraDeArte = _obraDeArteServicio.ObtenerObras();
            return View();
        }

        //Generar el código necesario para almacenar una nueva Obra de arte por medio del botón grabar
        [HttpPost]
        public ActionResult Agregar(ObraDeArte obraDeArte)
        {
            _obraDeArteServicio.Agregar(obraDeArte);
            //Una vez grabada, se debe redirigir a una acción llamada /ObrasDeArte/sigloxix 
            return RedirectToAction("sigloxix");
        }

        public ActionResult sigloxix()
        {
            ViewBag.ObraDeArte = _obraDeArteServicio.ObtenerSigloXIX(); ;
            return View();
        }

        // GET: ObrasDeArteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ObrasDeArteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ObrasDeArteController/Delete/5
        public ActionResult Eliminar(int id)
        {
            _obraDeArteServicio.Eliminar(id);
            return RedirectToAction("Index");
        }

        // POST: ObrasDeArteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
