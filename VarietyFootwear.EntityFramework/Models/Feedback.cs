using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarietyFootwear.EntityFramework.Models
{
    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        [Column("MailingListID")]
        public int MailingListId { get; set; }

        [StringLength(14)]
        public string EmailAddress { get; set; }

        [Column("Like_")]
        [StringLength(4)]
        public string Like { get; set; }

        [Column("Feedback")]
        [StringLength(26)]
        public string Feedback1 { get; set; }
    }
}