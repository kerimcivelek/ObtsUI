using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObtsUI.Shared.Dto.Operation
{
   public class OperationDto
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public int OperationTypeId { get; set; }
        public int? CustomerId { get; set; }

        [Required(ErrorMessage = "Zorunlu alan")]
        public int FirstKm { get; set; }
        public int LastKm { get; set; }
        public int PeriodKm { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public Guid key { get; set; }
    }
}
