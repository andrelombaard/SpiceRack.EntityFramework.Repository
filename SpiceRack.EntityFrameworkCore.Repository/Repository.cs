using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SpiceRack.EntityFrameworkCore.Repository
{
    public class Repository<TType, TDatabaseContext, TViewContext> : IRepository<TType>
        where TType : class
        where TDatabaseContext : DatabaseContext, new()
        where TViewContext : DatabaseContext, new()
    {
        protected readonly TDatabaseContext Context;
        protected readonly TViewContext ViewContext;

        protected Repository()
        {
            Context = new TDatabaseContext();
            ViewContext = new TViewContext();
        }

        public virtual void Dispose()
        {
            Context.Dispose();
        }

        public virtual TType Create(TType entity, bool saveChanges = true)
        {
            var propertyName = entity.GetType().Name;

            var propertyInfo = Context.GetType().GetProperty(propertyName);

            if (propertyInfo != null)
            {
                var methodInfo = propertyInfo.PropertyType.GetMethod("AddRange", new[] { typeof(TType[]) });
                methodInfo.Invoke(propertyInfo.GetValue(Context), new object[] { new[] { entity } });
            }

            if (saveChanges)
            {
                Context.SaveChanges();
            }

            return entity;
        }

        public virtual TType[] CreateRange(bool saveChanges = false, params TType[] entities)
        {
            var propertyName = typeof(TType).Name;

            var propertyInfo = Context.GetType().GetProperty(propertyName);

            if (propertyInfo != null)
            {
                var methodInfo = propertyInfo.PropertyType.GetMethod("AddRange", new[] { typeof(TType[]) });
                methodInfo.Invoke(propertyInfo.GetValue(Context), new object[] { entities });
            }

            if (saveChanges)
            {
                Context.SaveChanges();
            }

            return entities;
        }

        public virtual IQueryable<TType> Read(Expression<Func<TType, bool>> expression)
        {
            return Context.Set<TType>().Where(expression);
        }

        public virtual TType Update(TType entity, bool saveChanges = true)
        {
            Context.Entry(entity).State = EntityState.Modified;

            if (saveChanges)
            {
                Context.SaveChanges();
            }

            return entity;
        }

        public virtual void Delete(TType entity, bool saveChanges = true)
        {
            var propertyName = entity.GetType().Name;
            var propertyInfo = Context.GetType().GetProperty(propertyName);

            if (propertyInfo != null)
            {
                var methodInfo = propertyInfo.PropertyType.GetMethod("Remove");
                methodInfo.Invoke(propertyInfo.GetValue(Context), new object[] { entity });
            }

            if (saveChanges)
            {
                Context.SaveChanges();
            }
        }

        public virtual void Delete(int id)
        {
            var propertyName = typeof(TType).Name;

            Context.Database.ExecuteSqlCommand($@"DELETE FROM {propertyName} WHERE {propertyName}Id = {id}");
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
