using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class Student
    {
        public int ID { get; set; }
        public int Account_ID { get; set; }
        public int Class_ID { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Section> Section { get; set; }
        public virtual ICollection<Group> Group { get; set; }
        public virtual ICollection<Document> Document { get; set; }
    }
}