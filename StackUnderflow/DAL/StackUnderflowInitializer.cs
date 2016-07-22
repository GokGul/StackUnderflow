using StackUnderflow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackUnderflow.DAL
{
    public class StackUnderflowInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StackUnderflowContext>
    {
        protected override void Seed(StackUnderflowContext context)
        {
            var users = new List<User>
            {
                new User { Username="Hans", Email="hans@hotmail.com", Password="123456789" },
                new User { Username="Hamed", Email="hamed@hotmail.com", Password="123456789" },
                new User { Username="Abdoel", Email="abdoel@hotmail.com", Password="123456789" }
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var badges = new List<Badge>
            {
                new Badge { Name="Beginner Java", Level="Bronze", Requirement="Answer 10 Java related questions.", points=10, Users = new List<User> { users[0], users[1] } },
                new Badge { Name="Intermediate Java", Level="Silver", Requirement="Answer 30 Java related questions.", points=20 },
                new Badge { Name="Expert Java", Level="Gold", Requirement="Answer 50 Java related questions.", points=30 }
            };
            badges.ForEach(s => context.Badges.Add(s));
            context.SaveChanges();
            
            var questions = new List<Question>
            {
                new Question { Title="Who created Java?", Body="Who is the creator of Java? I would really like to know.", Date=DateTime.Now, User=users.First() },
                new Question { Title="What does MVVM stand for?", Body="I see this floating around everywhere.. What is it?", Date=DateTime.Now, User=users[1] },
                new Question { Title="Who is the creator of Java?", Body="Title..", Date=DateTime.Now, User=users.Last() }
            };
            questions.ForEach(s => context.Questions.Add(s));
            context.SaveChanges();

            var tags = new List<Tag>
            {
                new Tag { Name="Java", Questions = new List<Question> { questions[0], questions[2] }, Users = new List<User> { users[1], users[2] } },
                new Tag { Name="MVC", Questions = new List<Question> { questions[1] }, Users = new List<User> { users[0] } },
                new Tag { Name="Programming", Questions = new List<Question> { questions[0], questions[1], questions[3] }, Users = new List<User> { users[0], users[1], users[2] } }
            };
        }
    }
}