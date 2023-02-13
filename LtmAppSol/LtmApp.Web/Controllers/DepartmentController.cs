using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LtmApp.Web.Models;
using System.Collections.Generic;
using System;

namespace LtmApp.Web.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: DepartmentController
        public ActionResult Index()
        {
            List<DepartmentModel> departments = new List<DepartmentModel>()
            {
                new DepartmentModel()
                {
                    DepartmentID = 1,
                    StartDate = DateTime.Now,
                    Name = "Engineering",
                    Budget = 350000
                },
                new DepartmentModel()
                {
                    DepartmentID = 2,
                    StartDate = DateTime.Now,
                    Name = "English",
                    Budget = 120000
                },
                new DepartmentModel()
                {
                    DepartmentID = 3,
                    StartDate= DateTime.Now,
                    Name = "Economics",
                    Budget = 200000
                },
                new DepartmentModel()
                {
                    DepartmentID = 4,
                    StartDate = DateTime.Now,
                    Name = "Mathematics",
                    Budget = 250000
                }
            };
            return View(departments);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentController/Edit/5
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

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmentController/Delete/5
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
