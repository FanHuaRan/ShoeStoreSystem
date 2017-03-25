﻿using Pers.Fhr.ShoeStoreLib.Context;
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
        /// <summary>
        /// 自定义的组合查询
        /// </summary>
        /// <param name="delegates"></param>
        /// <returns></returns>
        public List<T> SimpleCompositeFind(params Func<T, bool>[] delegates)
        {
            return context.Set<T>()
                .Where(p => isRight(p, delegates))
                .ToList();
        }

        private bool isRight(T obj, params Func<T, bool> []delegates)
        {
            foreach (var v in delegates)
            {
                if (!v(obj))
                {
                    return false;
                }
            }
            return true;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
