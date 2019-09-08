using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace URISErrorUserDAL.Models.URIS2018_G1_M1.Classes
{
    public class ContextFactory : IDesignTimeDbContextFactory<ErrorDbContext>
    {
        public ErrorDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ErrorDbContext>();
            builder.UseSqlServer("Data Source = 147.91.175.176; Initial Catalog = URIS2018_G1_M1; User id = URIS2018_G1_M1; Password = URIS2018_Korisnici;");
            return new ErrorDbContext(builder.Options);
        }
    }
}