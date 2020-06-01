using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarietyFootwear.EntityFramework.Models
{
    public partial class Order
    {
        [Key]
        public int PurchaseOrderNumber { get; set; }

        [Column("CustomerID")]
        public long? CustomerId { get; set; }

        [StringLength(6)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string EmailName { get; set; }

        [StringLength(11)]
        public string ProductName { get; set; }

        public int? Size { get; set; }

        [StringLength(4)]
        public string Price { get; set; }

        [StringLength(6)]
        public string Section { get; set; }

        [StringLength(5)]
        public string Colour { get; set; }
    }
}