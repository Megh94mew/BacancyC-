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