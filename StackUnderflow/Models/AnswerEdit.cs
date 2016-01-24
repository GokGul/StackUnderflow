using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StackUnderflow.Models
{
    public class AnswerEdit
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Answer")]
        [DataType(DataType.MultilineText)]
        [StringLength(255, MinimumLength = 10)]
        [Required]
        public string Body { get; set; }

        [Display(Name = "Edited")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "Original")]
        public virtual Answer Answer { get; set; }

        [Display(Name = "By")]
        public virtual User User { get; set; }
    }
}