using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TimedAsmt.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Comment> Comments {get; set;}
        public DbSet<Hate> Hates {get; set;}
        public DbSet<Post> Posts {get; set;}
        public DbSet<Reply> Replies {get; set;}
    }
}