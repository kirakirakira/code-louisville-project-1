using System;
using System.Collections.Generic;

namespace code_louisville
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.age = 36;
            IncrementAge(student);

            Console.WriteLine(student.age);

            // string[] thing = { "English", "Spanish", "Japanese" };
            // student.languages = new List<string>(thing);
            student.languages = new List<string>() { "English", "Spanish", "Japanese" };

            student.PrintLanguages();

            student.classes = new List<string>() { "Python", "C#" };

            student.PrintClasses();

            Mentor mentor = new Mentor();
            mentor.age = 40;
            mentor.email = "bob@yahoo.com";
            mentor.yearsMentoring = 3;

            int monthsMentoring = mentor.MonthsMentoring();
            Console.WriteLine("Mentor has been mentoring for " + monthsMentoring + " months");
        }

        public static void IncrementAge(IPerson person)
        {
            person.age++;
        }
    }
}
