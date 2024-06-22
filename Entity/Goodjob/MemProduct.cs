using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int MemId { get; set; }
        public int CatalogId { get; set; }
        public int ProductTypeId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public byte IssueFlag { get; set; }
    }
}
