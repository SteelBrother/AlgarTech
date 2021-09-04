using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeveloperWEBAPI.Entidades;

namespace TestDeveloperWEBAPI.AccesoDatos
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
