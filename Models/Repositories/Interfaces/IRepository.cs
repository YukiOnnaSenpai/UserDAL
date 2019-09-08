namespace URISErrorUserDAL.Models.Repositories.Interfaces
{
    public interface IRepository <TEntity, K> where TEntity: class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(K id);
        TEntity GetById(K id); 
    }
}
