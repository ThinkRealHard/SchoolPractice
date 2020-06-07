using System;
using System.Collections.Generic;

namespace SchoolPractice
{

	public class Teacher
	{
		private string firstName { get; set; }
		private string lastName { get; set; }
		private string subject { get; set; }
		private int yearsTeaching { get; set; }

		public Teacher(string first, string last, string subject, int years)
		{
			this.firstName = first;
			this.lastName = last;
			this.subject = subject;
			this.yearsTeaching = years;
		}

		public Teacher(string first, string last, string subject)
        : this (first, last, subject, 0) { }

		public Teacher(string first, string last)
		: this (first, last, "new", 0) { }

		public Teacher()
		: this("John", "Doe") { }

		public string TeacherInfo()
        {
			return (firstName + " has been teaching " + subject + " over a career of " + yearsTeaching + " years.");
        }
	}
}
