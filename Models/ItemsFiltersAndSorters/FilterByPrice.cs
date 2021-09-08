using System;
using System.Collections.Generic;
using System.Linq;

namespace XESShop.Models.ItemsFiltersAndSorters
{
    public class FilterByPrice : IProductFilter
    {
        private readonly IProductFilter _productFilter;

        private readonly int _from;
        private readonly int _to;

        public FilterByPrice(int from, int to, IProductFilter productFilter = null)
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

        public void Filter(IList<IProduct> products)
        {
            products = products
                .Where(p => p.Price <= _from && p.Price >= _to)
                .ToList();

            _productFilter?.Filter(products);
        }
    }
}
