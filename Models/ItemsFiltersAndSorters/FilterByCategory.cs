using System;
using System.Collections.Generic;
using System.Linq;

namespace XESShop.Models.ItemsFiltersAndSorters
{
    public class FilterByCategory : IProductFilter
    {
        private readonly IProductFilter _productFilter;
        private readonly Category _category;

        public FilterByCategory(Category category, IProductFilter productFilter = null)
        {
            #region CheckInputData
            if (category is null)
                throw new ArgumentException("Manufacturer is null", nameof(category));
            #endregion

            _productFilter = productFilter;
            _category = category;
        }

        public void Filter(IList<IProduct> products)
        {
            products = products
                .Where(p => p.Category.Contains(_category))
                .ToList();

            _productFilter?.Filter(products);
        }
    }
}
