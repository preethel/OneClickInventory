﻿using System.ComponentModel.DataAnnotations;

namespace OneClickInventory.Models
{
    public class InvoiceType
    {
        public int InvoiceTypeId { get; set; }
        [Required]
        public string InvoiceTypeName { get; set; }
        public string Description { get; set; }
    }
}
