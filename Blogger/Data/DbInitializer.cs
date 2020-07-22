using Blogger.Models;
using System.Collections.Generic;
using System.Linq;

namespace Blogger.Data
{
    public class DbInitializer
    {
        public DbInitializer()
        {
        }

        public static void Initialize(BlogContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[] {
                new User
                {
                    FirstName = "William",
                    Id = "0",
                    LastName = "Jake",
                    Posts = new List<Post>
                {
                    new Post { Id = "0", Content = "Awesome story", UserId = "0" },
                    new Post { Id = "1", Content = "Content 2", UserId = "0" },
                    new Post { Id = "2", Content = "Content 3", UserId = "0" },
                    new Post { Id = "3", Content = "Content 4", UserId = "0" },
                }
                },
            new User
            {
                FirstName = "Peter",
                Id = "1",
                LastName = "Jackson",
                Posts = new List<Post>
                {
                    new Post { Id = "4", Content = "Awesome story Peter", UserId = "1" },
                    new Post { Id = "5", Content = "Content 2 Peter", UserId = "1" },
                    new Post { Id = "6", Content = "Content 3 Peter", UserId = "1" },
                    new Post { Id = "7", Content = "Content 4 Peter", UserId = "1" },
                }
            }
            };

            foreach (var user in users)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}