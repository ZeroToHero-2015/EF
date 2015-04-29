namespace Personal.Context
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Model;

    public class PersonalContext : DbContext
    {

        public PersonalContext() : base("Personal")
        {

        }

        public DbSet<Location> Locations { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ApplyCustomConventions(modelBuilder);
        }

        private void ApplyCustomConventions(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
        }
    }
}
