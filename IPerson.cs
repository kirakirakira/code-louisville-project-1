using System;
using System.Collections.Generic;

namespace code_louisville
{
    interface IPerson
    {
        int age { get; set; }
        string name { get; set; }
        string email { get; set; }
        List<string> languages { get; set; }

        void PrintLanguages();
    }
}
