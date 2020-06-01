﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VarietyFootwear.EntityFramework.Models
{
    public partial class Shoe
    {
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }

        [StringLength(14)]
        public string ProductName { get; set; }

        public long? ProductSize { get; set; }

        [StringLength(4)]
        public string UnitPrice { get; set; }

        [StringLength(5)]
        public string Colour { get; set; }

        [StringLength(6)]
        public string Section { get; set; }

        [StringLength(18)]
        public string Image { get; set; }
    }
}