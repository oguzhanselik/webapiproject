using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Proje.Models
{
    [Table("Stock")]
    public class Stock
    {   
        [Key][MaxLength(8)][Required][RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]    
        public string Name { get; set; }        
        public int Amount { get; set; }       
    }

}
