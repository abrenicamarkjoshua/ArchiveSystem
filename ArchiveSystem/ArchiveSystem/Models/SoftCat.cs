using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class SoftCat
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Software category must not be blank")]
        [Display(Name = "Software Category")]
        public string softCat { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}