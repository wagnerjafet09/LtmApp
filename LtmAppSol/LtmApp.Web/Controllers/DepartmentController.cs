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
using LtmApp.Web.ApiServices.Interfaces;

namespace LtmApp.Web.Controllers
{
    public class DepartmentController : Controller
    {
        HttpClientHandler handler = new HttpClientHandler();
        private readonly ILogger<DepartmentController> logger;
        private readonly IConfiguration configuration;
        private readonly IDepartmentApiService departmentApiService;
        private readonly string urlBase;

        public DepartmentController(ILogger<DepartmentController> logger, 
                                    IConfiguration configuration, 
                                    IDepartmentApiService departmentApiService)
        {
            this.logger = logger;
            this.configuration = configuration;
            this.departmentApiService = departmentApiService;
            this.urlBase = this.configuration["apiConfig:baseUrl"];
        }
        public async Task<ActionResult> Index()
        {
            DepartmentListResponse departmentList = new DepartmentListResponse();
            try
            {
                departmentList = await this.departmentApiService.GetDepartments();
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
                detailResponse = await this.departmentApiService.GetDepartment(id);
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
                commadResponse =  await this.departmentApiService.Save(createRequest);
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
                this.logger.LogError("Error obteniendo el detalle del departamento", ex.ToString());
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(DepartmentUpdateRequest departmentUpdateRequest)
        {
            CommadResponse commadResponse = new CommadResponse();
            try
            {
                commadResponse = await this.departmentApiService.Update(departmentUpdateRequest);

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
    }
}
