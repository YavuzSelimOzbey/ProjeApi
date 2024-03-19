using ProjeApi.DataAccess.Abstract;
using ProjeApi.DataAccess.Concrete.Context;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.DataAccess.EntityFreamwork
{
    public class EfProductDal : EfEntityRepositoryBase<Product, DataBaseContext>, IProductDal
    {
    }
}
