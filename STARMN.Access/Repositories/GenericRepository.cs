

using Microsoft.EntityFrameworkCore;
using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;

namespace STARMN.Access.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly STARMNDB _sTARMNDB;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(STARMNDB sTARMNDB)
    {
        _sTARMNDB = sTARMNDB;
        _dbSet = sTARMNDB.Set<TEntity>();
    }
    public void Delete(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            _sTARMNDB.SaveChanges();
        }
    }

    public List<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }

    public TEntity GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public List<TEntity> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Save(TEntity entity)
    {
        _dbSet.Add(entity);
        _sTARMNDB.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _sTARMNDB.SaveChanges();
    }
}
