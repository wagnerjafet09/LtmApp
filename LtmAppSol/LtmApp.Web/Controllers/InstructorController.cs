using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LtmApp.Web.Models;

namespace LtmApp.Web.Controllers
{
	public class InstructorController : Controller
	{
		// GET: InstructorController
		public ActionResult Index()
		{
			List<InstructorModel> instructors = new List<InstructorModel>()
			{
				new InstructorModel()
				{
					InstructorId = 1,
					HireDate = DateTime.Now,
					FirstName = "Wagner",
					LastName = "Matos"
				},
				new InstructorModel()
				{
					InstructorId = 2,
					HireDate = DateTime.Now,
					FirstName = "Eliezer",
					LastName = "Vargas"
				},
				new InstructorModel()
				{
					InstructorId = 3,
					HireDate = DateTime.Now,
					FirstName = "Rusbel",
					LastName = "Rodriguez"
				},
				new InstructorModel()
				{
					InstructorId = 4,
					HireDate = DateTime.Now,
					FirstName = "Mayerlin",
					LastName = "Vargas"
				}
			};
			return View(instructors);
		}

		// GET: InstructorController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: InstructorController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: InstructorController/Create
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

		// GET: InstructorController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: InstructorController/Edit/5
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

		// GET: InstructorController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: InstructorController/Delete/5
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
