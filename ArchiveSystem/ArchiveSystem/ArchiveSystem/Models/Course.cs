using ArchiveSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArchiveSystem.Models
{
    public class Course
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Course name must not be blank")]
        [StringLength(250)]
        [Display(Name="Course Name")]
        public string CourseName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        
    }
}