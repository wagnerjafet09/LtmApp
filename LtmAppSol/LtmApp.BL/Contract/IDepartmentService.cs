using LtmApp.BL.Core;
using LtmApp.BL.Dtos;

namespace LtmApp.BL.Contract
{
    public interface IDepartmentService : IBaseService
    {
        ServiceResult SaveDepartment(DepartmentAddDto departmentAdd);
        ServiceResult UpdateDepartment(DepartmentUpdateDto departmentUpdate);
        ServiceResult RemoveDepartment(DepartmentRemoveDto departmentRemove);

    }
}
