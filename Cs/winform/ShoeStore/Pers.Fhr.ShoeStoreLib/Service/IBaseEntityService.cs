using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    interface IBaseEntityService<T> where T:class
    {
        IList<T> FindAll();

        T FindById(Int64 id);

        T Update(T obj);

        void  DeleteById(Int64 id);
        T Save(T obj);
    }
}
