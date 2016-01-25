using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using StackUnderflow.Models;

namespace StackUnderflow.DAL
{
    public class StackUnderflowContext : DbContext
    {
        public StackUnderflowContext() : base("StackUnderflowContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionMarked> QuestionsMarked { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<QuestionEdit> QuestionsEdited { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerEdit> AnswersEdited { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}