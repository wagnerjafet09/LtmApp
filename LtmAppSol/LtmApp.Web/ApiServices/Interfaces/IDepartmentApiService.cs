using System.Threading.Tasks;
using LtmApp.Web.Models.Requests;
using LtmApp.Web.Models.Response;
namespace LtmApp.Web.ApiServices.Interfaces
{
    public interface IDepartmentApiService
    {
        Task<DepartmentListResponse> GetDepartments();
        Task<DepartmentDetailResponse> GetDepartment(int id);
        Task<CommadResponse> Update(DepartmentUpdateRequest deparmentUpdate);
        Task<CommadResponse> Save(DepartmentCreateRequest departmentCreate);
    }
}
