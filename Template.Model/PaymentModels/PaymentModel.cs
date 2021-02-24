using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Template.Model.PaymentModels
{
    public class PaymentModel
    {
        [Required]
        [Display(Name = "Student Identity")]
        public string StudentIdentity { get; set; }
        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }
        [Required]
        [Display(Name = "Payment Month")]
        public MonthsEnum Paymentmonth { get; set; }
        [Required]
        [Display(Name = "Payment Type")]
        public MonthsEnum Type { get; set; }
    }

}
