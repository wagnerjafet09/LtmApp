using LtmApp.Web.Exceptions;
using System;

namespace LtmApp.Web.Models
{
	public class InstructorModel: PersonModel
	{
		private int instructorId;
		public int InstructorId
		{
			get { return instructorId; }
			set
			{
				if (value == 0)
				{
					throw new InstructorException("InstructorId no puede ser null");
				}
				else
				{
					instructorId = value;
				}
			}
		}
		public DateTime HireDate { get; set; }
	}
}
