using ProjeApi.Entities.Concrete;

namespace ProjeApi.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        string Add(Product product);
        string Delete(Product product);
        string Update(Product product);
    }
}
