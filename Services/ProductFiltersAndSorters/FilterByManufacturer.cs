using System;
using System.Collections.Generic;
using System.Linq;

namespace XESShop.Models.ProductFiltersAndSorters
{
    public class FilterByManufacturer : IProductFilter
    {
        private readonly IProductFilter _productFilter;
        private readonly Manufacturer _manufacturer;

        public FilterByManufacturer(Manufacturer manufacturer, IProductFilter productFilter = null)
        {
            #region CheckInputData
            if (manufacturer is null)
                throw new ArgumentException("Manufacturer is null", nameof(manufacturer));
            #endregion

            _productFilter = productFilter;
            _manufacturer = manufacturer;
        }

        public IEnumerable<Product> Filter(IEnumerable<Product> products)
        {
            products = products
                .Where(p => p.Manufacturer.Id == _manufacturer.Id)
                .ToList();

            products = _productFilter?.Filter(products) ?? products;
            return products;
        }
    }
}
