using System;
using System.Collections.Generic;
using System.Text;

namespace cmts
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExpertiseLevel { get; set; }

        public ICollection<TrainingProgram> TrainingPrograms { get; set; }
    }

    public class TrainingProgram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExpertiseLevel { get; set; }
        
        public ICollection<TrainingProgram> trainingPrograms { get; set; }
    }
}
