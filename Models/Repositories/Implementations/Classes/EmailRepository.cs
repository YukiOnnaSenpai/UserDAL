using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace URISErrorUserDAL.Models.Repositories.Implementations.Classes
{
    public class EmailRepository : BaseRepositoryImpl<Email, int>
    {
        public override void Delete(int id)
        {
            context.Database.OpenConnection();
            Email trackEntity = context.Set<Email>().Where(e => e.EmailId == id).Select(e => e).AsQueryable().FirstOrDefault();
            trackEntity.IsActive = NOT_ACTIVE;
            context.Set<Email>().Update(trackEntity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }

        public override Email GetById(int id)
        {
            context.Database.OpenConnection();
            Email email = context.Set<Email>().Where(e => e.EmailId == id).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return email;
        }

        public Email GetByToken(string token) {

            context.Database.OpenConnection();
            Email email = context.Set<Email>().Where(e => e.Token == token).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return email;
        }
    }
}