using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Template.Core.Entities
{
    public class Student
    {
        //south african identity number
        public int Id { get; set; }
        public string Identity { get; set; }
        public int GuardianId { get; set; }
        public bool Active { get; set; }
        public int FormerSchoolId { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get { return Surname + ", " + FirstName; }
        }
        public string Nationality { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<StudentSubject> StudentSubjects { get; set; }
        public virtual Guardian Guradian { get; set; }
        public virtual FormerSchool FormerSchool { get; set; }
    }
}
