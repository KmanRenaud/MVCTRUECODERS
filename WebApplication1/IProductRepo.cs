using WebApplication1.Models;

namespace WebApplication1
{
    public interface IProductRepo
    {
        public IEnumerable<Products> GetAllProducts();

    }
}
