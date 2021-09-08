using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public interface IProduct
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        double Price { get; }

        Picture Photo { get; }
        List<Category> Category { get; }
        Manufacturer Manufacturer { get; }
    }
}
