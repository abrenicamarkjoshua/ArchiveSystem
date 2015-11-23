using ArchiveSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArchiveSystem.Models
{
    public class Program
    {
        public int ID { get; set; }
      //  [Required(ErrorMessage="*")]
        [StringLength(25)]
        [Display(Name="Program Name")]
        public string ProgramName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        //public virtual ICollection<Account> Students { get; set; }
        //public virtual ICollection<Document> Documents { get; set; }
    }
}