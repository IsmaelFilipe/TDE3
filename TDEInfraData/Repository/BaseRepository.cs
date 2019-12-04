using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;
using TDEDominio.Interface;
using TDEInfraData.Context;

namespace TDEInfraData.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {


        private CampanhaContext context = new CampanhaContext();

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }



        public T Select(int id)
        {
            return context.Set<T>().Find(id);
        }

        public T Select(string id)
        {
            return context.Set<T>().Find(id);
        }

        public IList<T> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
