using LtmApp.Web.ApiServices.Interfaces;
using LtmApp.Web.Models.Requests;
using LtmApp.Web.Models.Response;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LtmApp.Web.ApiServices.Services
{
    public class DepartmentApiService : IDepartmentApiService
    {
        HttpClientHandler handler = new HttpClientHandler();
        private readonly IConfiguration configuration;
        private readonly ILogger<DepartmentApiService> logger;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly string urlBase;

        public DepartmentApiService(IConfiguration configuration, ILogger<DepartmentApiService> logger, IHttpClientFactory httpClientFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.httpClientFactory = httpClientFactory;
            this.urlBase = this.configuration["apiConfig:baseUrl"];
        }
        public async Task<DepartmentDetailResponse> GetDepartment(int id)
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
            }
            catch (Exception ex)
            {
                detailResponse.success = false;
                detailResponse.message = this.configuration["departmentMessages:errorGetDepartment"];
                this.logger.LogError($"{detailResponse.message} : {ex.Message}", ex.ToString());
            }
            return detailResponse;
        }

        public async Task<DepartmentListResponse> GetDepartments()
        {
            DepartmentListResponse response = new DepartmentListResponse();
            try
            {
                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    using (var resp = await httpClient.GetAsync($"{this.urlBase}/Department"))
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            string jsonResp = await resp.Content.ReadAsStringAsync();
                            response = JsonConvert.DeserializeObject<DepartmentListResponse>(jsonResp);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.message = this.configuration["departmentMessages:errorGetDepartments"];
                this.logger.LogError($"{ response.message } : {ex.Message}",ex.ToString());
            }
            return response;
        }

        public async Task<CommadResponse> Save(DepartmentCreateRequest departmentCreate)
        {
            CommadResponse commadResponse = new CommadResponse();
            try
            {
                departmentCreate.CreationUser = 1;
                departmentCreate.CreationDate = DateTime.Now;
                departmentCreate.StartDate = DateTime.Now;
                StringContent content = new StringContent(JsonConvert.SerializeObject(departmentCreate), Encoding.UTF8, "application/json");
                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    httpClient.BaseAddress = new Uri(this.urlBase);
                    using (var resp = await httpClient.PostAsync($"{this.urlBase}/Department/SaveDepartment", content))
                    {

                        if (resp.IsSuccessStatusCode)
                        {
                            string apiResponse = await resp.Content.ReadAsStringAsync();
                            commadResponse = JsonConvert.DeserializeObject<CommadResponse>(apiResponse);
                        }
                        else
                        {
                            commadResponse.success = false;
                            commadResponse.message = this.configuration["departmentMessages:errorSaveDepartment"];
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                commadResponse.success = false;
                commadResponse.message = this.configuration["departmentMessages:errorSaveDepartment"];
                this.logger.LogError($" {commadResponse.message} : {ex.Message}", ex.ToString());
            }
            return commadResponse;
        }

        public async Task<CommadResponse> Update(DepartmentUpdateRequest deparmentUpdate)
        {
            CommadResponse commadResponse = new CommadResponse();
            try
            {
                deparmentUpdate.ModifyDate = DateTime.Now;
                deparmentUpdate.UserMod = 1;
                StringContent content = new StringContent(JsonConvert.SerializeObject(deparmentUpdate), Encoding.UTF8, "application/json");
                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    httpClient.BaseAddress = new Uri(this.urlBase);
                    using (var resp = await httpClient.PutAsync($"{this.urlBase}/Department/UpdateDepartment", content))
                    {



                        if (resp.IsSuccessStatusCode)
                        {
                            string apiResponse = await resp.Content.ReadAsStringAsync();
                            commadResponse = JsonConvert.DeserializeObject<CommadResponse>(apiResponse);
                        }
                        else
                        {
                            commadResponse.success = false;
                            commadResponse.message = this.configuration["errorMessage:errorUpdateMovie"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                commadResponse.success = false;
                commadResponse.message = this.configuration["errorMessage:errorUpdateMovie"];
                this.logger.LogError($" {commadResponse.message} : {ex.Message}", ex.ToString());
            }
            return commadResponse;
        }
    }
}
