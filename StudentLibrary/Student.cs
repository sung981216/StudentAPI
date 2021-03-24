using System;
using System.ComponentModel.DataAnnotations;

namespace StudentLibrary
{
	public class Student
	{
		public string StudentId { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string School { get; set; }

	}
}
