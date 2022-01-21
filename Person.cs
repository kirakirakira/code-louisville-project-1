using System;
using System.Collections.Generic;

namespace code_louisville
{
    class Person : IPerson
    {
        public int age { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public List<string> languages { get; set; }
    }
}