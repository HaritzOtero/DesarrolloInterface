using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookpadForm.models
{
    internal class CoockpadDBContext: DbContext
    {
        public CoockpadDBContext() : base(nameOrConnectionString: "CookpadDbContext")
        { }
        public DbSet<Errezeta> Errezeta { get; set; }
        public DbSet<Botoa> Botoa { get; set; }
        public DbSet<Erabiltzailea> Erabiltzailea { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
