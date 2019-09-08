using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace URISErrorUserDAL.Models.Repositories.Implementations.Classes
{
    public class PersonalAccountRepository : BaseRepositoryImpl<PersonalAccount, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            PersonalAccount trackEntity = context.Set<PersonalAccount>().Where(e => e.UserId == id).Select(e => e).AsQueryable().FirstOrDefault();
            trackEntity.IsActive = NOT_ACTIVE;
            context.Set<PersonalAccount>().Update(trackEntity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override PersonalAccount GetById(int id)
        {
            context.Database.OpenConnection();
            PersonalAccount personal = context.Set<PersonalAccount>().Where(e => e.UserId == id).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return personal;
        }
    }
}