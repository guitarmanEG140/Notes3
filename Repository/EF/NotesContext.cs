//using Notes.Models;
//using Microsoft.EntityFrameworkCore;

//namespace Notes.Data
//{
//    public class NotesContext : DbContext
//    {
//        public NotesContext(DbContextOptions<NotesContext> options) : base(options)
//        {
//        }

//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Note> Notes { get; set; }
//        public DbSet<User> Users { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Category>().ToTable("Category");
//            modelBuilder.Entity<Note>().ToTable("Note");
//            modelBuilder.Entity<User>().ToTable("User");
//        }
//    }
//}