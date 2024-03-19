using ProjeApi.Entities.Concrete;

namespace ProjeApi.Business.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAll();
        string Add(Stock stock); 
        string Delete(Stock stock);
        string Update(Stock stock);
    }
}
