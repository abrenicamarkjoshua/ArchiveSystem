using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArchiveSystem.Models
{
    public class Account
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
           
        [Required(ErrorMessage = "*")]
        [StringLength(10)]
        public string Role { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Registered")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        
    }
}