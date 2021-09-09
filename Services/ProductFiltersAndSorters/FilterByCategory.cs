using System;
using System.Collections.Generic;
using System.Linq;

namespace XESShop.Models.ProductFiltersAndSorters
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

        public IEnumerable<Product> Filter(IEnumerable<Product> products)
        {
            products = products
                .Where(p => p.CategoryId == _category.Id)
                .ToList();

            products = _productFilter?.Filter(products);
            return products;
        }
    }
}
