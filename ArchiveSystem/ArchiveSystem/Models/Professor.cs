using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class Professor
    {
        public int ID { get; set; }
        public virtual ICollection<Class> Class { get; set; }
        public virtual Account Account { get; set; }
    }
}