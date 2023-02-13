using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LtmApp.Web.Models;
using System.Collections.Generic;
using System;

namespace LtmApp.Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            List<StudentModel> students = new List<StudentModel>()
            {
                new StudentModel() 
                {
                    StudentId = 1,
                    EnrollmentDate = DateTime.Now,
                    FirstName = "Wagner",
                    LastName = "Matos"
                },
                new StudentModel()
                {
                    StudentId = 2,
                    EnrollmentDate = DateTime.Now,
                    FirstName = "Eliezer",
                    LastName = "Vargas"
                },
                new StudentModel()
                {
                    StudentId = 3,
                    EnrollmentDate = DateTime.Now,
                    FirstName = "Rusbel",
                    LastName = "Rodriguez"
                },
                new StudentModel()
                {
                    StudentId = 4,
                    EnrollmentDate = DateTime.Now,
                    FirstName = "Mayerlin",
                    LastName = "Vargas"
                }
            };

            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
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

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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
