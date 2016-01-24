using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StackUnderflow.Models
{
    public class Badge
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Level")]
        [DataType(DataType.Text)]
        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string Level { get; set; }

        [Display(Name = "Requirement")]
        [DataType(DataType.MultilineText)]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Requirement { get; set; }

        [Display(Name = "Points")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a number.")]
        [Required]
        public int points { get; set; }

        [Display(Name = "Users")]
        public virtual ICollection<User> Users { get; set; }
    }
    }
}