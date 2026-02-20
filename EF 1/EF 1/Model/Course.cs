using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace EF_1.Model
{
    public class Course
    {
        // Course Entity

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "decimal")]
        public int Fees { get; set; }
        public int DurationinMonths { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
