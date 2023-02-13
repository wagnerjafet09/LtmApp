using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LtmApp.Web.Models;

namespace LtmApp.Web.Controllers
{
    public class CourseController : Controller
    {
        // GET: CourseController
        public ActionResult Index()   
        {
            List<CourseModel> courses = new List<CourseModel>()
            {
                new CourseModel() 
                {
                    CourseId = 1,
                    Credits = 5,
                    Title = "Calculus",
                    DepartmentId = 2
                },
                new CourseModel()
                {
                    CourseId = 2,
                    Credits = 2,
                    Title  = "Chemistry",
                    DepartmentId = 1
                },
                new CourseModel()
                {
                    CourseId = 3,
                    Credits = 4,
                    Title  = "Physics",
                    DepartmentId = 1
                },
                new CourseModel()
                {
                    CourseId = 4,
                    Credits = 2,
                    Title  = "Poetry",
                    DepartmentId = 2
                }
            };
            return View(courses);
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
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

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
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

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
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
