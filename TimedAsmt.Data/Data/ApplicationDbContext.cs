using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TimedAsmt.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<comment> Comments {get; set;}
        public DbSet<Hate> Hates {get; set;}
        public DbSet<Post> Posts {get; set;}
        public DbSet<Reply> Replies {get; set;}
    }
}