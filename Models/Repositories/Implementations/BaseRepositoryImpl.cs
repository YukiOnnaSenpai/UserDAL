using Microsoft.EntityFrameworkCore;
using URISErrorUserDAL.Models.Repositories.Interfaces;

namespace URISErrorUserDAL.Models.Repositories.Implementations
{
    public abstract class BaseRepositoryImpl<TEntity,K>: IRepository<TEntity,K> where TEntity : class
    {
        protected const short ACTIVE = -1;
        protected const short NOT_ACTIVE = 0;
        protected ErrorDbContext context;
        protected DbSet<TEntity> DbSet;

        public void Add(TEntity entity) {
            context.Database.OpenConnection();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }
        public abstract void Delete(K id);
        public abstract TEntity GetById(K id);
        public void Update(TEntity entity) {
            context.Database.OpenConnection();
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
            context.Database.CloseConnection();
        }
    }
}