using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Template.Core.Entities
{
    public class Student
    {
        //south african identity number
        [Key]
        public string Identity { get; set; }
        [ForeignKey("Guardian")]
        public string Guradian_Identity { get; set; }
        [ForeignKey("School")]
        public int SchoolId { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Nationality { get; set; }
        public string CellNumber { get; set; }
        public bool Active { get; set; } = true;
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Guardian Attributes
        public virtual School School { get; set; }
        public Guardian Guardian { get; set; }
        public ICollection<Enrollement> Enrollements { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
