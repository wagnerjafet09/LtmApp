using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.BL.Dtos.Student
{
    public class StudentUpdateDto : StudentBaseDto
    {
        public int StudentId { get; set; }
        public int? UserMod { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
