using System;
using System.Collections.Generic;
using System.Text;

namespace ObtsUI.Shared.Dto.Customer
{
   public class DashboardDto
    {
        public string OperationTypeName { get; set; }
        public int totalOperation { get; set; }
        public decimal totalPrice { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
    }
}
