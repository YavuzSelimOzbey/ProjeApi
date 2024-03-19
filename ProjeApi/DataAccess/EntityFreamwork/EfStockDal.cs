using ProjeApi.DataAccess.Abstract;
using ProjeApi.DataAccess.Concrete.Context;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.DataAccess.EntityFreamwork
{
    public class EfStockDal : EfEntityRepositoryBase<Stock, DataBaseContext>, IStockDal
    {
    }
}
