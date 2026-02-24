using System;
using System.Collections.Generic;
using System.Text;

namespace cmts
{
    public class Department_entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
