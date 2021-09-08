using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models.ItemsFiltersAndSorters
{
    public interface IProductFilter
    {
        void Filter(IList<IProduct> products);
    }
}
