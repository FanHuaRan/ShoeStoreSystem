using Pers.Fhr.ShoeStoreLib.Service;
using ShoeStoreMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Service
{
    public interface IShoeItemService : IBaseEntityService<ShoeItem>
    {
        IEnumerable<float> FindShoeItemSizes(IEnumerable<ShoeItem> shoeItems);

        IEnumerable<float> FindShoeItemSizes();

        IEnumerable<string> FindShoeItemColors(IEnumerable<ShoeItem> shoeItems);

        IEnumerable<string> FindShoeItemColors();

    }
}
