using Notes.Models;
using System;
using System.Linq;

namespace Notes.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NotesContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var Users = new User[]
            {
            new User{ID=1,Email="ross80@lsus.edu",Name = "Stephen",CreatedOn=DateTime.Parse("2005-09-01")}
            };
            foreach (User u in Users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var Categories = new Category[]
            {
            new Category{ID=1,Name = "Ask A Question"},

            };
            foreach (Category c in Categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var Notes = new Note[]

            {
            new Note{ID=1,Title="My Question",Notes="This is my notes",CategoryID = 1, IsDeleted = false, userID = 1 }

            };
            foreach (Note n in Notes)
            {
                context.Notes.Add(n);
            }
            context.SaveChanges();
        }
    }
}
