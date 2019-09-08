using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace URISErrorUserDAL.Models.Repositories.Implementations.Classes
{
    public class AddressRepository : BaseRepositoryImpl<Address,int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            Address trackEntity = context.Set<Address>().Where(e => e.AddressId == id).Select(e => e).AsQueryable().FirstOrDefault();
            trackEntity.IsActive = NOT_ACTIVE;
            context.Set<Address>().Update(trackEntity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override Address GetById(int id)
        {
            context.Database.OpenConnection();
            Address address = context.Set<Address>().Where(e => e.AddressId == id).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return address;
        }
    }
}