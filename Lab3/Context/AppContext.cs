using Lab3.Models;
using System.Data.Entity;

namespace Lab3.Context
{
    public class AppContext: DbContext
    {
        public AppContext() : base("DefaultConnection") { }
        public DbSet<Student> Students { get; set; }
    }
}