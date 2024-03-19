using ProjeApi.DataAccess.Abstract;
using ProjeApi.DataAccess.Concrete.Context;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.DataAccess.EntityFreamwork
{
    public class EfReportDal : EfEntityRepositoryBase<Report, DataBaseContext>, IReportDal
    {
    }
}
