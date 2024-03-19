using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProjeApi.Entities.Concrete
{
    public class Product:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public DateTime? SilinmeZamani { get; set; }
        public bool SilindiMi { get; set; }
    }
}
