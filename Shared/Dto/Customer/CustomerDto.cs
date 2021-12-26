using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObtsUI.Shared.Dto.Customer
{
   public class CustomerDto
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }

        [Required(ErrorMessage = "Plaka Alanı Zorunludur")]
        public string Plaka { get; set; }

        [Required(ErrorMessage = "Yıl alanı Zorunludur")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Yakıt türü alanı Zorunludur")]
        public string Fuel { get; set; }

        [Required(ErrorMessage ="Marka alanı Zorunludur")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Müşteri Adı Alanı Zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Müşteri Soyadı Alanı Zorunludur")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Gsm Alanı Zorunludur")]
        [StringLength(11)]
        public string Gsm { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
        public Guid key { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
     
    }
}
