using System;
using System.Collections.Generic;

namespace code_louisville
{
    class Student : Person
    {
        public bool hasHomework { get; set; }
        public int grade { get; set; }

        public List<string> classes { get; set; }

        public void PrintClasses()
        {
            foreach (string learning in classes)
            {
                Console.WriteLine(learning);
            }
        }
    }
}
