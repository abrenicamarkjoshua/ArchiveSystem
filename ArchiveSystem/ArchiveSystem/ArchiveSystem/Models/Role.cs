using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class Role
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string role { get; set; }

    }
}