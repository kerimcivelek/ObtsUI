using System;
using System.Collections.Generic;
using System.Text;

namespace ObtsUI.Shared.Dto.Product
{
   public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
