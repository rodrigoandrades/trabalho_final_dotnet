namespace WCFReader
{
    using System.Data.Entity;

    public partial class DbModel : DbContext
    {
        public DbModel() : base("name=db")
        {
        }

        public virtual DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notification>()
                .Property(e => e.mensagem)
                .IsUnicode(false);
        }
    }
}
