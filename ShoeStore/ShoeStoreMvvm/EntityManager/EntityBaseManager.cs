using Pers.Fhr.ShoeStoreLib.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pers.Fhr.ShoeStoreLib.Component;
using System.Data.Entity;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// 实体访问泛型基类
    /// 2016/12/26 fhr
    /// </summary>
    class EntityBaseManager<T> :IEntityManager<T> where T : class
    {
        protected readonly MyContext context = ContextFactory.GetContext();
        public void Delete(T obj)
        {
            context.Set<T>().Remove(obj);
            context.SaveChanges(); 
        }

        public T Insert(T obj)
        {
            try
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
                return obj;
            }
            catch
            {
                return null;
            }
        }

        public T Update(T obj)
        {
           object key= ObjectRefletUtil.GetMainKeyValue(obj);
           T oldObj = context.Set<T>().Find(key);
            if (oldObj == null)
            {
                return null;
            }
            ObjectRefletUtil.SetValue<T>(oldObj, obj);
            context.Entry<T>(oldObj).State = EntityState.Modified;
            context.SaveChanges();
            return oldObj;
        }

        public  List<T> FindAll()
        {
            return context.Set<T>().Select(p => p).ToList<T>();
        }

        public void DeleteById(long id)
        {
            T model = FindById(id);
            if (model != null)
            {
                context.Set<T>().Remove(model);
                context.SaveChanges();
            }  
        }
        public T FindById(long id)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> FindByLinq(Func<T, bool> expression)
        {
            return context.Set<T>()
                .Where(expression)
                .Select(p => p)
                .ToList();
        }
        public List<object> FindByWhereAndSelect(Func<T, bool> whereExpression, Func<T, object> selectExpression)
        {
            return context.Set<T>()
                .Where(whereExpression)
                .Select(selectExpression)
                .ToList();
        }
        public List<V> FindBySelect<V>(Func<T, V> selectExpression)
        {
            return context.Set<T>()
                .Select(selectExpression)
                .ToList<V>();
        }
        /// <summary>
        /// 自定义的组合查询
        /// 不提倡
        /// </summary>
        /// <param name="delegates"></param>
        /// <returns></returns>
        public List<T> SimpleCompositeFind(params Func<T, bool>[] delegates)
        {
            if (delegates.Length == 0)
            {
                return new List<T>();
            }
            var objects = context.Set<T>().Where(delegates[0]).Select(p => p);
            for (int i = 1; i < delegates.Length; i++)
            {
                var condition = delegates[i];
                objects = objects.Where(condition).Select(p => p).AsQueryable<T>();
            }
            return objects.ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
