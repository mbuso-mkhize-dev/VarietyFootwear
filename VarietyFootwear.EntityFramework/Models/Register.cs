using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarietyFootwear.EntityFramework.Models
{
    [Table("Register")]
    public partial class Register
    {
        [Key]
        [Column("UserID")]
        [StringLength(13)]
        public string UserId { get; set; }

        [StringLength(7)]
        public string Name { get; set; }

        [StringLength(7)]
        public string LastName { get; set; }

        [StringLength(13)]
        public string Address { get; set; }

        [StringLength(4)]
        public string Postcode { get; set; }

        [StringLength(6)]
        public string City { get; set; }

        [StringLength(15)]
        public string EmailAdress { get; set; }

        [Column("Password_")]
        [StringLength(8)]
        public string Password { get; set; }

        [StringLength(10)]
        public string CreditCardNumber { get; set; }
    }
}