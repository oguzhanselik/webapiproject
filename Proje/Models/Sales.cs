using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.Models
{
    [Table("Sales")]
    public class Sales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [MaxLength(8)]
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }       
        public decimal TotalPrice { get; set; }
    }


}
