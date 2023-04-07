using LtmApp.Web.ApiServices.Interfaces;
using LtmApp.Web.Models;
using LtmApp.Web.Models.Requests;
using LtmApp.Web.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LtmApp.Web.Controllers
{
    public class StudentController : Controller
    {
        HttpClientHandler handler = new HttpClientHandler();
        private readonly ILogger<StudentController> logger;
        private readonly IConfiguration configuration;
        private readonly IStudentApiService studentApiService;
        private readonly string urlBase;

        public StudentController(ILogger<StudentController> logger, 
                                    IConfiguration configuration,
                                    IStudentApiService studentApiService)
        {
            this.logger = logger;
            this.configuration = configuration;
            this.studentApiService = studentApiService;
            this.urlBase = this.configuration["apiConfig:baseUrl"];
        }

        // GET: StudentController
        public async Task<ActionResult> Index()
        {
            StudentListResponse studentList = new StudentListResponse();

            try
            {
                /*using (var httpClient = new HttpClient(this.handler)) 
                {
                    var response = await httpClient.GetAsync($"{ this.urlBase }/Student");

                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();

                        studentList = JsonConvert.DeserializeObject<StudentListResponse>(apiResult);
                    }
                    else 
                    {
                        // Poner x Logica 
                    }

                }*/
                studentList = await this.studentApiService.GetStudents();

                return View(studentList.data);

            }
            catch (Exception ex)
            {

                this.logger.LogError("Error obteniendo los estudiantes.", ex.ToString());
            }

            return View();
        }

        // GET: StudentController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            StudentDetailResponse detailResponse= new StudentDetailResponse();

            try
            {
                /*using (var httpClient = new HttpClient(this.handler))
                {
                    var response = await httpClient.GetAsync($"{ this.urlBase }/Student/{ id }");

                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();

                        detailResponse = JsonConvert.DeserializeObject<StudentDetailResponse>(apiResult);
                    }
                    else
                    {
                        // Poner x Logica 
                    }

                }*/

                detailResponse = await this.studentApiService.GetStudent(id);

                return View(detailResponse.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo el detalle del estudiante.", ex.ToString());
            }

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
        public async Task<ActionResult> Create(StudentCreateRequest createRequest)
        {
            CommadResponse commadResponse = new CommadResponse();

            try
            {
                /*createRequest.CreationDate = DateTime.Now;
                createRequest.CreationUser = 1;

                using (var httpClient = new HttpClient(this.handler))
                {
                    StringContent request = new StringContent(JsonConvert.SerializeObject(createRequest), Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync($"{this.urlBase}/Student/SaveStudent", request);

                    string apiResult = await response.Content.ReadAsStringAsync();

                    commadResponse = JsonConvert.DeserializeObject<CommadResponse>(apiResult);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = commadResponse.message;
                        return View();
                    }
                }*/

                commadResponse = await this.studentApiService.Save(createRequest);

                if (commadResponse.success) 
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = commadResponse.message;
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            StudentDetailResponse detailResponse = new StudentDetailResponse();

            try
            {
                /*using (var httpClient = new HttpClient(this.handler))
                {
                    var response = await httpClient.GetAsync($"{this.urlBase}/Student/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();

                        detailResponse = JsonConvert.DeserializeObject<StudentDetailResponse>(apiResult);
                    }
                    else
                    {
                        // Poner x Logica 
                    }

                }*/

                detailResponse = await this.studentApiService.GetStudent(id);

                return View(detailResponse.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo el detalle del estudiante.", ex.ToString());
            }

            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(StudentUpdateRequest studentUpdate)
        {
            CommadResponse commadResponse = new CommadResponse();
            try
            {
                /*studentUpdate.ModifyDate = DateTime.Now;
                studentUpdate.UserMod = 1;

                using (var httpClient = new HttpClient(this.handler))
                {
                    StringContent request = new StringContent(JsonConvert.SerializeObject(studentUpdate),Encoding.UTF8, "application/json");

                    var response = await httpClient.PutAsync($"{this.urlBase}/Student/UpdateStudent", request);

                    string apiResult = await response.Content.ReadAsStringAsync();

                    commadResponse = JsonConvert.DeserializeObject<CommadResponse>(apiResult);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = commadResponse.message;
                        return View();
                    }
                }*/

                commadResponse = await this.studentApiService.Update(studentUpdate);

                if (commadResponse.success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = commadResponse.message;
                    return View();
                }
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
