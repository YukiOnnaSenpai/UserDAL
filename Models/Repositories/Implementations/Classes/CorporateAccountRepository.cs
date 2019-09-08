using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace URISErrorUserDAL.Models.Repositories.Implementations.Classes
{
    public class CorporateAccountRepository : BaseRepositoryImpl<CorporateAccount, int>
    {

        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            CorporateAccount trackEntity = context.Set<CorporateAccount>().Where(e => e.CorporateId == id).Select(e => e).AsQueryable().FirstOrDefault();
            trackEntity.IsActive = NOT_ACTIVE;
            context.Set<CorporateAccount>().Update(trackEntity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override CorporateAccount GetById(int id)
        {
            context.Database.OpenConnection();
            CorporateAccount corporate = context.Set<CorporateAccount>().Where(e => e.CorporateId == id).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return corporate;
        }

    }
}