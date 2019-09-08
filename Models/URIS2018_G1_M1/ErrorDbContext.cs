using Microsoft.EntityFrameworkCore;

namespace URISErrorUserDAL.Models
{
    public class ErrorDbContext : DbContext
    {
        public ErrorDbContext(DbContextOptions options)  : base(options){ }
        public DbSet<Address> Address { get; set; }
        public DbSet<CorporateAccount> CorporateAccount { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<PersonalAccount> PersonalAccount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PersonalAccount>().HasMany(u => u.Addresses).WithOne(p => p.UserId);
            modelBuilder.Entity<PersonalAccount>().HasMany(u => u.Emails).WithOne(p => p.UserId);
            modelBuilder.Entity<CorporateAccount>().HasMany(u => u.Addresses).WithOne(p => p.CorporateId);
            modelBuilder.Entity<CorporateAccount>().HasMany(u => u.Emails).WithOne(p => p.CorporateId);
            modelBuilder.Entity<CorporateAccount>().HasMany(u => u.UsersBound).WithOne(p => p.CorporateId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = 147.91.175.176; Initial Catalog = URIS2018_G1_M1; User id = URIS2018_G1_M1; Password = URIS2018_Korisnici;");
        }
    }
}