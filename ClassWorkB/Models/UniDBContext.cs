using System.Data.Entity;

namespace ClassWorkB.Models
{
    public class UniDBContext : DbContext
    {
        public UniDBContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Student> Students { get; set; }
    }

}