using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StackUnderflow.Models
{
    public class QuestionEdit
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 10)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Question")]
        [DataType(DataType.MultilineText)]
        [StringLength(255, MinimumLength = 10)]
        [Required]
        public string Body { get; set; }

        [Display(Name = "Edited")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "Original")]
        public virtual Question Question { get; set; }

        [Display(Name = "By")]
        public virtual User User { get; set; }
    }
}