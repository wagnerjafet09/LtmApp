using LtmApp.Web.ApiServices.Interfaces;
using LtmApp.Web.Models.Requests;
using LtmApp.Web.Models.Responses;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LtmApp.Web.ApiServices.Services
{
    public class StudentApiService : IStudentApiService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<StudentApiService> logger;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly string urlBase;

        public StudentApiService(IConfiguration configuration, 
                                    ILogger<StudentApiService> logger, 
                                    IHttpClientFactory httpClientFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.httpClientFactory = httpClientFactory;
            this.urlBase = this.configuration["apiConfig:baseUrl"];
        }

        public Task<StudentDetailResponse> GetStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<StudentListResponse> GetStudents()
        {
            StudentListResponse response = new StudentListResponse();
            try
            {
                using (var httpClient = this.httpClientFactory.CreateClient()) 
                {
                    using (var resp = await httpClient.GetAsync($"{this.urlBase}/Student")) 
                    {
                        if (resp.IsSuccessStatusCode) 
                        {
                            string jsonResp = await resp.Content.ReadAsStringAsync();
                            response = JsonConvert.DeserializeObject<StudentListResponse>(jsonResp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.success = false;
                response.message = this.configuration["studentMessages:errorGetStudents"];
                this.logger.LogError($"{response.message} : {ex.Message}", ex.ToString());
            };
            return response;
        }

        public async Task<CommadResponse> Save(StudentCreateRequest studentCreate)
        {
            CommadResponse commadResponse = new CommadResponse();
            try
            {
                studentCreate.CreationDate = DateTime.Now;
                studentCreate.CreationUser = 1;

                StringContent request = new StringContent(JsonConvert.SerializeObject(studentCreate), Encoding.UTF8, "application/json");

                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    httpClient.BaseAddress = new Uri(this.urlBase);
                    using (var resp = await httpClient.PostAsync($"{this.urlBase}/Student/SaveStudent", request))
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            string apiResult = await resp.Content.ReadAsStringAsync();

                            commadResponse = JsonConvert.DeserializeObject<CommadResponse>(apiResult);
                        }
                        else 
                        {
                            commadResponse.success = false;
                            commadResponse.message = this.configuration["studentMessages:errorSaveStudents"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                commadResponse.success = false;
                commadResponse.message = this.configuration["studentMessages:errorSaveStudents"];
                this.logger.LogError($"{commadResponse.message} : {ex.Message}", ex.ToString());
            }
            return commadResponse;
        }

        public Task<CommadResponse> Update(StudentUpdateRequest studentUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}
