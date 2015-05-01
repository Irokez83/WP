using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WishApp.Models
{
    public enum Occasionals { Birthday, Christmas, Anniversary, Valentines, Other }

    public class Preference
    {
        [Key]
        public int PreferenceId { get; set; }

        [EnumDataType(typeof(Occasionals))]
        [Display(Name = "Please choose occasion:")]
        public Occasionals Occasions { get; set; }

        [Display(Name = "Type in your gift expectation:")]
        [StringLength(50, ErrorMessage = "No more than 50 characters allowed for preference description")]
        [DataType(DataType.Text)]
        [RegularExpression("^([0-9A-Za-z #.,])+$", ErrorMessage = "Preference must be properly formatted (no unusual characters allowed).")]
        public string UserPreference { get; set; }

        [Display(Name = "Flowers YES/NO")]
        public bool Flowers { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}