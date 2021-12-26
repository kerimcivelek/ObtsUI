using System;
using System.Collections.Generic;
using System.Text;

namespace ObtsUI.Shared.Dto.Login
{
   public class TokenDto
    {
        public string Token { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public Guid key { get; set; }
        public string role { get; set; }
    }
}
