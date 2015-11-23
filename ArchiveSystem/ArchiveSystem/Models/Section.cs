using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class Section
    {
        public int ID { get; set; }
        public string section { get; set; }
        public virtual Class Class { get; set; }
        public virtual ICollection<Group> Group { get; set; }
    }
}