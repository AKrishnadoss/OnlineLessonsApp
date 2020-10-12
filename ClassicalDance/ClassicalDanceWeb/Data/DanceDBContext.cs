using ClassicalDanceWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalDanceWeb.Data
{
    public class DanceDBContext : DbContext
    {
        public DanceDBContext(DbContextOptions<DanceDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
