using System;
using System.Collections.Generic;
using System.Text;

namespace ObtsUI.Shared.Dto.Operation
{
   public class OperationPrintDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Plaka { get; set; }
        public string Brand { get; set; }
        public string Year { get; set; }
        public string Fuel { get; set; }
        public string NameSurname { get; set; }
        public string Gsm { get; set; }
        public int FirstKm { get; set; }
        public int LastKm { get; set; }
        public int PeriodKm { get; set; }
        public string OperationName { get; set; }
        public string CompanyName { get; set; }
    }
}
