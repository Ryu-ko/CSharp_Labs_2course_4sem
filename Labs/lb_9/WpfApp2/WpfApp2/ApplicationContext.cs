using Microsoft.EntityFrameworkCore;

namespace WpfApp2
{
    public partial class ApplicationContext : DbContext
    {
        public virtual DbSet<PUBLISHER> PUBLISHER { get; set; }
        public virtual DbSet<AUTHOR> AUTHOR { get; set; }
        public virtual DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=WIN-DRMTP6R6BKI;Initial Catalog=app1;Integrated Security=True");
        }
    }
}
