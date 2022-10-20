using Dapper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductsRepos : IProductRepo
    {

        private readonly IDbConnection _conn;
        public ProductsRepos(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _conn.Query<Products>("SELECT * FROM PRODUCTS;");
        }

    }
}
