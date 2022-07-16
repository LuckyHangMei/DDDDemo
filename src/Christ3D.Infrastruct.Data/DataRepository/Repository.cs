using Christ3D.Domain.Interfaces;
using Christ3D.Infrastruct.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Infrastruct.Data.DataRepository
{
    /// <summary>
    /// 基础设施层。是实现领域层的的接口
    /// ，在这个基础设施层中，会有很多很多的内容，比如验证层，IoC层，事务，工作单元等等，
    /// 以后都会说到，至少从名字上你也能明白——基础设施，这些基础东西是不能放在领域层的，
    /// 这是肯定的，因为我们关心的是业务领域，这个不是我们的业务，也不会是下文的应用层，至于为什么，
    /// 你可以先想一想，数据验证和AOP这些为何不放在应用层。
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly  StudyContext Db;

        protected readonly DbSet<TEntity> DbSet;
        public Repository(StudyContext studyContext)
        {
            Db = studyContext;
            DbSet = Db.Set<TEntity>();
        }
        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public  void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual TEntity GetById(Guid id)
        {
           return  DbSet.Find(id);
        }

        public virtual void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }
    }
}
