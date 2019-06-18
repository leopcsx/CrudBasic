using CRUDBasic.Application.Interface;
using CRUDBasic.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDBasic.MVC.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly IColaboradorAppService _colaboradorAppService;

        public ColaboradorController(IColaboradorAppService colaboradorAppService)
        {
            _colaboradorAppService = colaboradorAppService;
        }

        // GET: Colaborador
        public ActionResult Index()
        {
            return View(_colaboradorAppService.GetAll());
        }

        // GET: Colaborador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Colaborador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colaborador/Create
        [HttpPost]
        public ActionResult Create(ColaboradorViewModel colaboradorViewModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(colaboradorViewModel);

                _colaboradorAppService.Add(colaboradorViewModel);

                return View(colaboradorViewModel);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Colaborador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Colaborador/Edit/5
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

        // GET: Colaborador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Colaborador/Delete/5
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
