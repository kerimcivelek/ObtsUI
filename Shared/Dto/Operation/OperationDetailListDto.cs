using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObtsUI.Shared.Dto.Operation
{
   public class OperationDetailListDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime RegisterDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SumPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Discount { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Total { get; set; }
        public string ExternalProduct { get; set; }
        public string Note { get; set; }

        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int OperationId { get; set; }
        public bool ExtProduct { get; set; }
    }
}
