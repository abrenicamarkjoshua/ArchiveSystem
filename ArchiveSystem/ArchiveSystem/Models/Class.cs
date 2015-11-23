using ArchiveSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArchiveSystem.Models
{
    public class Class
    {
        public int ID { get; set; }
        public int Course_ID { get; set; }
        public int Program_ID { get; set; }
        public string AcademicYear { get; set; }
        public string AcademicTerm { get; set; }
        public virtual Course Course { get; set; }
        public virtual Program Program { get; set; }
        public ICollection<Student> Student { get; set; }
        public ICollection<Professor> Professor { get; set; }
        public ICollection<Section> Section { get; set; }



    }


}