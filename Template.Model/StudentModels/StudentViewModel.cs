using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Model.StudentModels
{
    public class StudentViewModel
    {
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
    }
}
