using System;

namespace code_louisville
{
    class Mentor : Person
    {
        public int yearsMentoring { get; set; }

        public int MonthsMentoring()
        {
            return yearsMentoring * 12;
        }
    }
}
