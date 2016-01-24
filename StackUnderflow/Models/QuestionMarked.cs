using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StackUnderflow.Models
{
    public class QuestionMarked
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Marked")]
        [Required]
        public Mark? Marked { get; set; }

        [Display(Name = "Reason")]
        [DataType(DataType.MultilineText)]
        [StringLength(255, MinimumLength = 10)]
        public string Reason { get; set; }

        [Display(Name = "Duplicate of")]
        public virtual Question DuplicateOf { get; set; } 
    }

    public enum Mark
    {
        DUPLICATE,
        UNCLEAR,
        OFFTOPIC
    }
}