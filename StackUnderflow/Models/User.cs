using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackUnderflow.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string Username { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(128)]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8)]
        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        [Display(Name = "Retype Password")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8)]
        [Required]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Badges")]
        public virtual ICollection<Badge> Badges { get; set; }

        [Display(Name = "Questions")]
        public virtual ICollection<Question> Questions { get; set; }

        [Display(Name = "Skills")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}