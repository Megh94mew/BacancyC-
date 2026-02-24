using System;
using System.Collections.Generic;
using System.Text;

namespace cmts
{
    public class Training_Program
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DurationDays { get; set; }
        public DateTime StartDate { get; set; }

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

           public ICollection<Enrollment> Enrollments { get; set; }
    }
}
