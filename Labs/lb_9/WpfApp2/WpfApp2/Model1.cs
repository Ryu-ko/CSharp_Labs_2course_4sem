using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfApp2
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AUTHOR> AUTHOR { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<PUBLISHER> PUBLISHER { get; set; }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<AUTHOR>()
                .Property(e => e.serial)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<PUBLISHER>()
                .Property(e => e.country)
                .IsFixedLength();

            modelBuilder.Entity<PUBLISHER>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
