using System;
using System.Collections.Generic;
using System.Text;
using Template.Model.StudentModels;

namespace Template.Model.PaymentModels
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public string Month { get; set; }
        public string  Type { get; set; }

    }
}
