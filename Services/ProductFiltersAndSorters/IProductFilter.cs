using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models.ProductFiltersAndSorters
{
    public interface IProductFilter
    {
        IEnumerable<Product> Filter(IEnumerable<Product> products);
    }
}
