using LtmApp.Web.ApiServices.Interfaces;
using LtmApp.Web.Models.Request;
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
    public class CourseApiService : ICourseApiService

    {
        private readonly IConfiguration configuration;
        private readonly ILogger<CourseApiService> logger;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly string urlBase;

        public CourseApiService(IConfiguration configuration, ILogger<CourseApiService> logger, IHttpClientFactory httpClientFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.httpClientFactory = httpClientFactory;
            this.urlBase = this.configuration["apiConfig:baseUrl"];
        }

        public async Task<CourseDetailResponse> GetCourse(int id)
        {
            CourseDetailResponse response = new CourseDetailResponse();
            try
            {
                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    using (var resp = await httpClient.GetAsync($"{this.urlBase}/Course/{id}"))
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            string jsonResponse = await resp.Content.ReadAsStringAsync();
                            response = JsonConvert.DeserializeObject<CourseDetailResponse>(jsonResponse);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = this.configuration["courseMessages:errorGetCourse"];
                this.logger.LogError($"{ response.Message } : { ex.Message }", ex.ToString());
            }
            return response;
        }




        public async Task<CourseListResponse> GetCourses()
        {
            CourseListResponse response = new CourseListResponse();
            try
            {
                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    using (var resp = await httpClient.GetAsync($"{this.urlBase}/Course"))
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            string jsonResp = await resp.Content.ReadAsStringAsync();
                            response = JsonConvert.DeserializeObject<CourseListResponse>(jsonResp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = this.configuration["courseMessages:errorGetCourses"];
                this.logger.LogError($"{ response.Message } : { ex.Message }", ex.ToString());
            }
            return response;
        }




        public async Task<CommandResponse> Save(CourseCreateRequest courseCreate)
        {
            CommandResponse commandResp = new CommandResponse();
            try
            {
                courseCreate.CreationDate = DateTime.Now;
                courseCreate.CreationUser = 1;

                StringContent request = new StringContent(JsonConvert.SerializeObject(courseCreate), Encoding.UTF8, "application/Json");

                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    using (var resp = await httpClient.PostAsync($"{this.urlBase}/Course/SaveCourse", request))
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            string apiResult = await resp.Content.ReadAsStringAsync();
                            commandResp = JsonConvert.DeserializeObject<CommandResponse>(apiResult);
                        }
                        else 
                        {
                            commandResp.success = false;
                            commandResp.message = this.configuration["courseMessages:errorSaveCourses"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                commandResp.success = false;
                commandResp.message = this.configuration["courseMessages:errorSaveCourses"];
                this.logger.LogError($"{commandResp.message} : {ex.Message}", ex.ToString());
            }
            return commandResp;
        }



        public async Task<CommandResponse> Update(CourseUpdateRequest courseUpdate)
        {
            CommandResponse commandResponse = new CommandResponse();
            try
            {
                courseUpdate.ModifyDate = DateTime.Now;
                courseUpdate.UserMod = 1;
                StringContent request = new StringContent(JsonConvert.SerializeObject(courseUpdate), Encoding.UTF8, "application/Json");

                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    using (var resp = await httpClient.PutAsync($"{this.urlBase}/Course/UpdateCourse", request))
                    {
                        if (resp.IsSuccessStatusCode)
                        {
                            string apiResult = await resp.Content.ReadAsStringAsync();
                            commandResponse = JsonConvert.DeserializeObject<CommandResponse>(apiResult);
                        }
                        else
                        {
                            commandResponse.success = false;
                            commandResponse.message = this.configuration["courseMessages:errorUpdateCourse"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                commandResponse.success = false;
                commandResponse.message = this.configuration["courseMessages:errorUpdateCourse"];
                this.logger.LogError($"{commandResponse.message} : {ex.Message}", ex.ToString());
            }
            return commandResponse;
        }
    }
}
