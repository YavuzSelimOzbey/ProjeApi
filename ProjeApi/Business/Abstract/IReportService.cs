using ProjeApi.Entities.Concrete;

namespace ProjeApi.Business.Abstract
{
    public interface IReportService
    {
        List<Report> GetAll();
        string Add(Report report);
        string Delete(Report report);
        string Update(Report report);
    }
}
