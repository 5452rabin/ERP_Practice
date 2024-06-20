using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practise.Models
{
    public class Sale
    {
        [Key]
        public int saleId { get; set; }
        public int quantity { get; set; }
        public decimal rate { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order order { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
