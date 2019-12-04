using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;
using TDEDominio.Interface;
using TDEInfraData.Repository;

namespace TDEServico.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Remove(int id)
        {

            repository.Remove(id);
        }


        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }

        public T Select(string userID)
        {
            return repository.Select(userID);
        }

        public T Select(int id)
        {
            return repository.Select(id);
        }

        public IList<T> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
