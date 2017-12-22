namespace ProcesoShneider.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Gateway> Gateway { get; set; }
        public virtual DbSet<LightMeter> LightMeter { get; set; }
        public virtual DbSet<WaterMeter> WaterMeter { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
