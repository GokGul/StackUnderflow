using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackUnderflow.Models
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Answer")]
        [DataType(DataType.MultilineText)]
        [StringLength(255, MinimumLength = 10)]
        [Required]
        public string Body { get; set; }

        [Display(Name = "Added")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "Question")]
        public virtual Question Question { get; set; }

        [Display(Name = "Answered by")]
        public virtual User User { get; set; }
    }
}