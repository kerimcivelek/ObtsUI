using System;
using System.Collections.Generic;
using System.Text;

namespace ObtsUI.Shared.Dto.Customer
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int CustomerId { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
