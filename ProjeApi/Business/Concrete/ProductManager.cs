using ProjeApi.Business.Abstract;
using ProjeApi.DataAccess.Abstract;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public string Add(Product product)
        {
            _productDal.Add(product);
            return "Ürün eklendi.";

        }

        public string Delete(Product product)
        {
            _productDal.Delete(product);
            return "Ürün silindi.";

        }

        public List<Product> GetAll()
        {
            return new List<Product>(_productDal.GetList().ToList());
        }

        public string Update(Product product)
        {
            _productDal.Update(product);
            return "Ürün bilgileri güncellendi.";
        }
    }
}
