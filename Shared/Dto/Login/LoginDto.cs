using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ObtsUI.Shared.Dto.Login
{
   public class LoginDto : MessageModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Zorunludur")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre Zorunludur")]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid key { get; set; }
        public bool Status { get; set; }
        public string Role { get; set; }
    }
}
