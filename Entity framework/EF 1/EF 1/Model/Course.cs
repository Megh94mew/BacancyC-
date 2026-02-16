using System;
using System.Collections.Generic;
using System.Text;

namespace EF_1.Model
{
    public class Course
    {
        // Course Entity

        public int Id { get; set; }
        public string Title { get; set; }
        public int Fees { get; set; }
        public int DurationinMonths { get; set; }

    }
}
