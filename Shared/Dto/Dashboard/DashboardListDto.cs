using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObtsUI.Shared.Dto.Dashboard
{
   public class DashboardListDto
    {
        public string OperationTypeName { get; set; }
        public int totalOperation { get; set; }
        public decimal totalPrice { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }


        
    }
}
