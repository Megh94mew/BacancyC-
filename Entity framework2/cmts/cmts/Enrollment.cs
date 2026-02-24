using System;
using System.Collections.Generic;
using System.Text;

namespace cmts
{
    public class Enrollment
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int TrainingProgramId { get; set; }
        public int Trainingprogram TrainingProgram { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public int performanceScore { get; set; }

    }
}
