using EF_1.Model;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_1.Model
{
    public class trainer
    {
        // Trainer entity
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExperienceYears { get; set; }
        public ICollection<trainer> trainers { get; set; }

    }
}
 
public class Trainer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ExperienceYears { get; set; }
}

public class batch 
{
  public int Id { get; set; }
  public DateTime StartDate { get; set; }
  public int CourseId { get; set; }
  public int TrainerId { get; set; }
}