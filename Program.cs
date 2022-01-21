using System;

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
        }

        public static void IncrementAge(IPerson person)
        {

        }
    }
}
