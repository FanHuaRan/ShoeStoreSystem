using Pers.Fhr.ShoeStoreLib.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    class AbstractEntityBaseClass<T>
        :IBaseEntityService<T>
        where T:class
    {
        protected IEntityManager<T> entityManager = null;
        public List<T> FindAll()
        {
            return entityManager.FindAll();
        }
        public T FindById(long id)
        {
            return entityManager.FindById(id);
        }
        public T Save(T obj)
        {
           return this.entityManager.Insert(obj);
        }
        public T Update(T obj)
        {
           return entityManager.Update(obj);
        }

        public void DeleteById(long id)
        {
            entityManager.DeleteById(id);
        }
    }
}
