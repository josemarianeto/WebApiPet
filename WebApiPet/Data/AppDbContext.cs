using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPet.Controllers;

namespace WebApiPet.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {

        }

        public DbSet<Users> User { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }

        public DbSet<Pet> Pet { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
