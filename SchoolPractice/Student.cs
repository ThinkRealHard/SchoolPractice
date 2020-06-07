using System;

namespace SchoolPractice
{
    public class Student
    {
        private string Name { get; set; }
        private int StudentId { get; set; }
        private int NumberOfCredits { get; set; }
        private double Gpa { get; set; }
        private static int nextStudentId = 1;
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            this.Name = name;
            this.StudentId = studentId;
            this.NumberOfCredits = numberOfCredits;
            this.Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

    }
}