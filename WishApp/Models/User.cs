using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WishApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "No more than 50 characters allowed for e-mail")]
        [Display(Name = "Please provide valid E-mail address")]
        public string Email { get; set; }
        
        //each user has a collection of preferences
        List<Preference> prefs { get; set; }
    }
}