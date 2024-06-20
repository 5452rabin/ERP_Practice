using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practise.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public decimal total { get; set; }
        public DateTime createddate { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }



    }
}
