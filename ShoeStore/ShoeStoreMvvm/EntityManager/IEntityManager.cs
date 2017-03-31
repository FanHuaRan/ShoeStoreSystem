using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.EntityManager
{
    /// <summary>
    /// 实体访问基本接口
    /// 2016/12/26 fhr
    /// </summary>
    interface IEntityManager<T> : IDisposable
    {
        T FindById(Int64 id);
        void Delete(T obj);
        T Insert(T obj);
        T Update(T obj);
        List<T> FindAll();
        List<T> SimpleCompositeFind(params Func<T, bool>[] delegates);
        void DeleteById(Int64 id);
        List<T> FindByLinq(Func<T, bool> expression);
        List<object> FindByWhereAndSelect(Func<T, bool> whereExpression, Func<T, object> selectExpression);
        List<V> FindBySelect<V>(Func<T, V> selectExpression);
    }
}
