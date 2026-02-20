using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_1.Model
{
    public class batch
    {
        // Batch Entity 

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        [ForeignKey("Course")]

        public int CourseId { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
    }
}
