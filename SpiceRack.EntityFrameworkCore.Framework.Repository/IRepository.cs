using System;
using System.Linq;
using System.Linq.Expressions;

namespace SpiceRack.EntityFrameworkCore.Framework.Repository
{
    public interface IRepository<TType> : IDisposable
    {
        TType Create(TType entity, bool saveChanges = true);
        TType[] CreateRange(bool saveChanges = true, params TType[] entities);
        IQueryable<TType> Read(Expression<Func<TType, bool>> expression);
        TType Update(TType entity, bool saveChanges = true);
        void Delete(TType entity, bool saveChanges = true);
        void Delete(int id);
        void SaveChanges();
    }
}
