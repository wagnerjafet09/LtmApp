using LtmApp.BL.Core;
using LtmApp.BL.Dtos.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Contract
{
    public interface IStudentService : IBaseService
    {
        ServiceResult SaveStudent(StudentSaveDto saveDto);
        ServiceResult UpdateStudent(StudentUpdateDto updateDto);
        ServiceResult RemoveStudent(StudentRemoveDto removeDto);
    }
}
