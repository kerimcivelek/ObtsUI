using System;
using System.Collections.Generic;
using System.Text;

namespace ObtsUI.Shared.Dto.Product
{
   public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
    }
}
