using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObtsUI.Shared.Dto.Operation
{
   public class OperationDetailDto
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan *")]
        public int OperationId { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan *")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan *")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan *")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan *")]
        public decimal Price { get; set; }

        public decimal Discount { get; set; }
        public bool ExternalProduct { get; set; }
        public string Note { get; set; }
    }
}
