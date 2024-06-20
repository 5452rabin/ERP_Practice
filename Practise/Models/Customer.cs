using System.ComponentModel.DataAnnotations;

namespace Practise.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
    }
}
