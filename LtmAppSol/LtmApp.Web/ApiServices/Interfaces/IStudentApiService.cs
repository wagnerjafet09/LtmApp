using LtmApp.Web.Models.Requests;
using LtmApp.Web.Models.Responses;
using System.Threading.Tasks;

namespace LtmApp.Web.ApiServices.Interfaces
{
    public interface IStudentApiService
    {
        Task<StudentListResponse> GetStudents();
        Task<StudentDetailResponse> GetStudent(int id);
        Task<CommadResponse> Update(StudentUpdateRequest studentUpdate);
        Task<CommadResponse> Save(StudentCreateRequest studentCreate);
    }
}
