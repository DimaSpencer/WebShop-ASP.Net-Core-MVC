using System;
using System.Collections.Generic;
using System.Linq;

namespace XESShop.Models.ProductFiltersAndSorters
{
    public class FilterByPrice : IProductFilter
    {
        private readonly IProductFilter _productFilter;

        private readonly decimal _from;
        private readonly decimal _to;

        public FilterByPrice(decimal from, decimal to, IProductFilter productFilter = null)
        {
            #region CheckInputData
            if (from < 0 || to < 0)
                throw new ArgumentException("Переменная from или to меньше нуля", nameof(from));
            if (from > to)
                throw new ArgumentException("Переменная from больше to");
            #endregion

            _productFilter = productFilter;
            _from = from;
            _to = to;
        }

        public IEnumerable<Product> Filter(IEnumerable<Product> products)
        {
            products = products
                .Where(p => p.Price <= _from && p.Price >= _to)
                .ToList();

            products = _productFilter?.Filter(products) ?? products;
            return products;
        }
    }
}
