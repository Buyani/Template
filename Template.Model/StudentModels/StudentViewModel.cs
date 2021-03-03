using System;
using System.Collections.Generic;
using System.Text;
using Template.Model.GuardianModels;
using Template.Model.PaymentModels;
using Template.Model.SchoolModels;
using Template.Model.SubjectModels;

namespace Template.Model.StudentModels
{
    public class StudentViewModel
    {
        public string Identity { get; set; }
        public string SubjectList { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Nationality { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public DateTime DateCreated { get; set; }

        public GuardianViewModel Parent { get; set; }
        public SchoolsViewModel School { get; set; }
        public ICollection<PaymentViewModel> Payments { get; set; }
        public ICollection<EnrollementViewModel> Enrollements { get; set; }


    }
}
