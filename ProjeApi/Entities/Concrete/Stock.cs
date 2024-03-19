using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProjeApi.Entities.Concrete
{
    public class Stock:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int StokAdeti { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public bool SilindiMi { get; set; }
    }
}
