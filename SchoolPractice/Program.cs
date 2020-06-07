using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student allen = new Student("Allen", 1, 1, 4.0);
            Teacher moe = new Teacher("Moe", "Alali", "Coding", 5);
            Console.WriteLine(allen.StudentInfo());
            Console.WriteLine(moe.TeacherInfo());
        }
    }
}
