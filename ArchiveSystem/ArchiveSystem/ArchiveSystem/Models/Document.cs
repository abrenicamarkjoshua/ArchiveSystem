using ArchiveSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class Document
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "File name must not be blank")]
        [StringLength(250)]
        public string Filename { get; set; }

        [Required(ErrorMessage = "Title must not be blank")]
        [StringLength(300)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author must not be blank")]
        [StringLength(250)]
        public string Author { get; set; }
        public int YearPublished { get; set; }
        
        

        [DataType(DataType.Date)]
        [Display(Name = "Date Uploaded")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateUploaded { get; set; }
        public int StudentID { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string Status { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Approved/Rejected")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateUpdated { get; set; }

        


        [StringLength(500)]
        public string Remarks { get; set; }

        
        public int SoftCat_ID { get; set; }
        public virtual SoftCat SoftCat { get; set; }
        public virtual Student student { get; set; }
        //public virtual Program Program { get; set; }
        //public virtual Course Course { get; set; }
    }
}