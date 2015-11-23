using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class Group
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Group name must not be blank")]
        [StringLength(250)]
        [Display(Name = "Group name")]
        public string GroupName { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual Section Section { get; set; }
    }
}