using System;
using System.Collections.Generic;

namespace SchoolPractice
{
	public class Course
	{
		private int CourseSize { get; set; }
		private string CourseName { get; set; }
		private string GradeSystem { get; set; }
		private List<Student> Roster { get; set; }
	//	private Student empty = new Student("Placeholder before student assignment");
	//	private List<Student> emptyRoster = new List<Student> { empty };

		public Course(int size, string name, string gradeSystem, List<Student> roster)
        {
			this.CourseSize = size;
			this.CourseName = name;
			this.GradeSystem = gradeSystem;
			this.Roster = roster;
        }

	//	public Course(int size, string name, string gradeSystem)
	//		: this(size, name, gradeSystem, emptyRoster) { }
	}
}
