using LtmApp.BL.Core;
using LtmApp.BL.Dto.Course;

namespace LtmApp.BL.Contract
{
    public interface ICourseService : IBaseService
    {
        ServiceResult SaveCourse(CourseSaveDto saveDto);
        ServiceResult UpdateCourse(CourseUpdateDto updateDto);
        ServiceResult RemoveCourse(CourseRemoveDto removeDto);
    }
}
