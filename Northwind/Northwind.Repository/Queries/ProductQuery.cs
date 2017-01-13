using System;
using System.Linq;
using System.Linq.Expressions;
using Northwind.Entities.Models;
using Repository.Pattern.Ef6;

namespace Northwind.Repository.Queries
{
    public class ProductQuery : QueryObject<Product>
    {
        public ProductQuery ProductsWithOrderCount()
        {
            
            return this;
        }
    }
}