using ManagermentStore.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagermentStore.Infrastructure
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
    {
        private ManagermentStoreContext _dbContext;
        private readonly DbSet<Entity> _dbSet;
        private readonly IUnitOfWork _unitOfWork;
        public BaseRepository(ManagermentStoreContext dbContext, IUnitOfWork unitOfWork)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Entity>();
            _unitOfWork = unitOfWork;
        }
        public int Add(Entity entity)
        {
            _dbSet.Add(entity);
            return _unitOfWork.Commit();
        }

        public int Delete(Guid Id)
        {
            var entity = GetById(Id);
            _dbSet.Remove(entity);
            return _unitOfWork.Commit();
        }

        public IEnumerable<Entity> GetAll()
        {
            return _dbSet.ToList();
        }

        public int Update(Entity entity)
        {
            _dbSet.Update(entity);
            return _unitOfWork.Commit();
        }

        public Entity GetById(Guid Id)
        {
            return _dbSet.Find(Id);
        }
    }
}
