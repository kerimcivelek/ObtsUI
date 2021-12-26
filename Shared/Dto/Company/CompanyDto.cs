using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace ObtsUI.Shared.Dto.Company
{
   public class CompanyDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan *")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan *")]
        public string Owner { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan *")]
        public string Gsm { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
