using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LtmApp.Web.Models;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using LtmApp.Web.Models.Responses;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using LtmApp.Web.Models.Request;
using LtmApp.Web.ApiServices.Interfaces;

namespace LtmApp.Web.Controllers
{
    public class CourseController : Controller
    {
        HttpClientHandler handler = new HttpClientHandler();
        private readonly ILogger<CourseController> logger;
        private readonly IConfiguration configuration;
        private readonly ICourseApiService courseApiService;
        private readonly string urlBase;

        public CourseController(ILogger<CourseController>logger,
                                IConfiguration configuration,
                                ICourseApiService courseApiService)
        {
            this.logger = logger;
            this.configuration = configuration;
            this.courseApiService = courseApiService;
            this.urlBase = this.configuration["apiConfig:baseUrl"];
        }

        public async Task<ActionResult> Index()   
        {
            CourseListResponse courseList = new CourseListResponse();
            try
            {
                //using (var httpclient = new HttpClient(this.handler)) 
                //{
                //    var response = await httpclient.GetAsync($"{ this.urlBase }/Course");
                //    if (response.IsSuccessStatusCode)
                //    {
                //        string apiResult = await response.Content.ReadAsStringAsync();

                //        courseList = JsonConvert.DeserializeObject<CourseListResponse>(apiResult);
                //    }
                //    else
                //    {
                //        //ponemos la logica a hacer
                //    }
                //}

                courseList = await this.courseApiService.GetCourses();

                return View(courseList.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo los cursos.", ex.ToString());
            }
            return View();
        }

        



        public async Task<ActionResult> Details(int id)
        {
            CourseDetailResponse detailResponse = new CourseDetailResponse();
            try
            {
                //using (var httpclient = new HttpClient(this.handler))
                //{
                //    var response = await httpclient.GetAsync($"{this.urlBase}/Course/{ id }");
                //    if (response.IsSuccessStatusCode)
                //    {
                //        string apiResult = await response.Content.ReadAsStringAsync();

                //        detailResponse = JsonConvert.DeserializeObject<CourseDetailResponse>(apiResult);
                //    }
                //    else
                //    {
                //        //ponemos la logica a hacer
                //    }
                //}

                detailResponse = await this.courseApiService.GetCourse(id);
                return View(detailResponse.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo el detalle del curso.", ex.ToString());
            }
            return View();
        }





        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CourseCreateRequest createRequest)
        {
            CommandResponse commandResponse = new CommandResponse();
            try
            {
                commandResponse = await this.courseApiService.Save(createRequest);

                if (commandResponse.success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = commandResponse.message;
                    return View();
                }
                //createRequest.CreationDate = DateTime.Now;
                //createRequest.CreationUser = 1;

                //using (var httpclient = new HttpClient(this.handler))
                //{
                //    StringContent request = new StringContent(JsonConvert.SerializeObject(createRequest), Encoding.UTF8, "application/Json");
                //    var response = await httpclient.PostAsync($"{this.urlBase}/Course/SaveCourse", request);

                //    string apiResult = await response.Content.ReadAsStringAsync();

                //    commandResponse = JsonConvert.DeserializeObject<CommandResponse>(apiResult);

                //    if (response.IsSuccessStatusCode)
                //    {
                //        return RedirectToAction(nameof(Index));
                //    }
                //    else
                //    {
                //        ViewBag.Message = commandResponse.message;
                //        return View();
                //    }
                //}
            }
            catch
            {
                return View();
            }
        }



        public async Task<ActionResult> Edit(int id)
        {
            CourseDetailResponse detailResponse = new CourseDetailResponse();
            try
            {
                using (var httpclient = new HttpClient(this.handler))
                {
                    var response = await httpclient.GetAsync($"{this.urlBase}/Course/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();

                        detailResponse = JsonConvert.DeserializeObject<CourseDetailResponse>(apiResult);
                    }
                    else
                    {
                        //ponemos la logica a hacer
                    }
                }
                return View(detailResponse.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo el detalle del curso.", ex.ToString());
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CourseUpdateRequest courseUpdate)
        {
            CommandResponse commandResponse = new CommandResponse();
            try
            {

                commandResponse = await this.courseApiService.Update(courseUpdate);

                if (commandResponse.success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = commandResponse.message;
                    return View();
                }


                //courseUpdate.ModifyDate = DateTime.Now;
                //courseUpdate.UserMod = 1;

                //using (var httpclient = new HttpClient(this.handler))
                //{ 
                //    StringContent request = new StringContent(JsonConvert.SerializeObject(courseUpdate),Encoding.UTF8, "application/Json");
                //    var response = await httpclient.PutAsync($"{this.urlBase}/Course/UpdateCourse", request);

                //    string apiResult = await response.Content.ReadAsStringAsync();

                //    commandResponse = JsonConvert.DeserializeObject<CommandResponse>(apiResult);

                //    if (response.IsSuccessStatusCode)
                //    {
                //        return RedirectToAction(nameof(Index));
                //    }
                //    else
                //    {
                //        ViewBag.Message = commandResponse.message;
                //        return View();
                //    }
                //}
     
            }
            catch
            {
                return View();
            }
        }

    }
}
