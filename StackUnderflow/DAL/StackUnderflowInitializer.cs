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
                new Badge { Name="Beginner Java", Level="Bronze", Requirement="Answer 10 Java related questions.", points=10},
                new Badge { Name="Intermediate Java", Level="Silver", Requirement="Answer 30 Java related questions.", points=20},
                new Badge { Name="Expert Java", Level="Gold", Requirement="Answer 50 Java related questions.", points=30}
            };
            badges.ForEach(s => context.Badges.Add(s));
            context.SaveChanges();


        }
    }
}