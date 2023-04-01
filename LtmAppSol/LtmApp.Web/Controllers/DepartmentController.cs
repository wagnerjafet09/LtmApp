using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LtmApp.Web.Models;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using LtmApp.Web.Models.Response;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LtmApp.Web.Models.Requests;
using System.Text;

namespace LtmApp.Web.Controllers
{
    public class DepartmentController : Controller
    {
        HttpClientHandler handler = new HttpClientHandler();
        private readonly ILogger<DepartmentController> logger;
        private readonly IConfiguration configuration;
        private readonly string urlBase;

        public DepartmentController(ILogger<DepartmentController> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
            this.urlBase = this.configuration["apiConfig:baseUrl"];
        }
        public async Task<ActionResult> Index()
        {
            DepartmentListResponse departmentList = new DepartmentListResponse();
            try
            {
                using (var httpClient = new HttpClient(this.handler))
                {
                    var response = await httpClient.GetAsync($"{this.urlBase}/Department");
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();
                        departmentList = JsonConvert.DeserializeObject<DepartmentListResponse>(apiResult);
                    }
                    else
                    {

                    }
                }
                return View(departmentList.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo los departamentos",ex.ToString());
            }
            return View();
        }
        public async Task<ActionResult> Details(int id)
        {
            DepartmentDetailResponse detailResponse = new DepartmentDetailResponse();
            try
            {
                using (var httpClient = new HttpClient(this.handler))
                {
                    var response = await httpClient.GetAsync($"{this.urlBase}/Department/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();
                        detailResponse = JsonConvert.DeserializeObject<DepartmentDetailResponse>(apiResult);
                    }
                    else
                    {

                    }
                }
                return View(detailResponse.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo el detalle del departamentos", ex.ToString());
            }
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(DepartmentCreateRequest createRequest)
        {
            CommadResponse commadResponse = new CommadResponse();
            try
            {
                using (var httpClient = new HttpClient(this.handler))
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(createRequest), Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync($"{this.urlBase}/Department/SaveDepartment", content);
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    commadResponse = JsonConvert.DeserializeObject<CommadResponse>(apiResponse);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = commadResponse.message;
                        return View();
                    }
                }
            }
            catch
            {
                return View();
            }
        }
   


        public async Task<ActionResult> Edit(int id)
        {
            DepartmentEditResponse editResponse = new DepartmentEditResponse();
            try
            {
                using (var httpClient = new HttpClient(this.handler))
                {
                    var response = await httpClient.GetAsync($"{this.urlBase}/Department/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();
                        editResponse = JsonConvert.DeserializeObject<DepartmentEditResponse>(apiResult);
                    }
                    else
                    {

                    }
                }
                return View(editResponse.data);
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo el detalle del departamentos", ex.ToString());
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(DeparmentUpdateRequest deparmentUpdateRequest)
        {
            CommadResponse commadResponse = new CommadResponse();
            try
            {
                deparmentUpdateRequest.ModifyDate = DateTime.Now;
                deparmentUpdateRequest.UserMod = 1;
                using (var httpClient = new HttpClient(this.handler))
                {
                    StringContent request = new StringContent(JsonConvert.SerializeObject(deparmentUpdateRequest),Encoding.UTF8,"application/json");
                    var response = await httpClient.PutAsync($"{this.urlBase}/Department/UpdateDepartment", request);
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
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
