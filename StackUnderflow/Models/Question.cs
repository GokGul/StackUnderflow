using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackUnderflow.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        
        [Display(Name = "Added")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "Asked by")]
        public virtual User User { get; set; }

        [Display(Name = "Marked")]
        public virtual ICollection<QuestionMarked> QuestionMarked { get; set; }

        [Display(Name = "Tags")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}