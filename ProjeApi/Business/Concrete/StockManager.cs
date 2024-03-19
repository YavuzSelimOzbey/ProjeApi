using ProjeApi.Business.Abstract;
using ProjeApi.DataAccess.Abstract;
using ProjeApi.DataAccess.EntityFreamwork;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.Business.Concrete
{
    public class StockManager : IStockService
    {
        private IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public string Add(Stock stock)
        {
            _stockDal.Add(stock);
            return "Stok eklendi.";
        }

        public string Delete(Stock stock)
        {
            _stockDal.Delete(stock);
            return "Stok silindi.";
        }
        public string Update(Stock stock)
        {
            _stockDal.Update(stock);
            return "Stok bilgileri güncellendi.";
        }

        public List<Stock> GetAll()
        {
            return new List<Stock>(_stockDal.GetList().ToList());
        }
    }
}
