using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StackUnderflow.Models
{
    public class Tag
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Questions")]
        public virtual ICollection<Question> Questions { get; set; }

        [Display(Name = "Users")]
        public virtual ICollection<User> Users { get; set; }
    }
}