using LtmApp.Web.Models;
using System;

namespace LtmApp.Web.Exceptions
{
	public class InstructorException: Exception
	{
		public InstructorException(string message) : base(message)
		{

		}
	}
}
