using ProjeApi.Business.Abstract;
using ProjeApi.DataAccess.Abstract;
using ProjeApi.DataAccess.EntityFreamwork;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private IReportDal _reportDal;
        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public string Add(Report report)
        {
            _reportDal.Add(report);
            return "Rapor eklendi.";

        }

        public string Delete(Report report)
        {
            _reportDal.Delete(report);
            return "Rapor silindi.";

        }
        public string Update(Report report)
        {
            _reportDal.Update(report);
            return "Rapor güncellendi.";
        }

        public List<Report> GetAll()
        {
            return new List<Report>(_reportDal.GetList().ToList());
        }

    }
}
