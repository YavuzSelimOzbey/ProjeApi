using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProjeApi.Entities.Concrete
{
    public class Report:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int StokId { get; set; }
        public int StokAdeti { get; set; }
        public DateTime StokOlusturulmaZamani { get; set; }
    }
}
