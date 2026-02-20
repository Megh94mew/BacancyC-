using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_1.Model
{
    public class student
    {
        // student entity

        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<student> students { get; set; }
    }
}




