using LtmApp.Web.Models.Request;
using LtmApp.Web.Models.Responses;
using System.Threading.Tasks;

namespace LtmApp.Web.ApiServices.Interfaces
{
    public interface ICourseApiService
    {
        Task<CourseListResponse> GetCourses();

        Task<CourseDetailResponse> GetCourse(int id);

        Task<CommandResponse> Update(CourseUpdateRequest courseUpdate);

        Task<CommandResponse> Save(CourseCreateRequest courseCreate);


    }
}
