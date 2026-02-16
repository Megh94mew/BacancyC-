using System;
using System.Collections.Generic;
using System.Text;

namespace EF_1.Model
{
    public class student
    {
        // student entity 

        public int Id { get; set; }
        public string Name { get; set; }
        public int Email { get; set; }
        public DateOnly CreatedDate { get; set; }
    }
}
