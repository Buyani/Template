using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Template.Core.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public string StudentIdentity { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Month { get; set; }
        public string Paymenttype { get; set; }        
        public virtual Student Student { get; set; }
    }
}
