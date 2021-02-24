using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Template.Model.SchoolModels;
using Template.Model.SubjectModels;

namespace Template.Model.StudentModels
{
    public class StudentModel
    {
        [Required]
        [Display(Name = "Identity")]
        public string Identity { get; set; }
        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        [Required]
        [Display(Name = "CellNumber")]
        public string CellNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Telephone")]
        public string TelephoneNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        [Required]
        [Display(Name = "Title")]
        public TittleEnum Title { get; set; }
        public int SchoolId { get; set; }

        //Guardian Information
        [Required]
        [Display(Name = "Title")]
        public TittleEnum Guardian_Title { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string Guardian_FirstName { get; set; }
        [Required]
        [Display(Name = "Surname")]
        public string Guardian_Surname { get; set; }
        [Required]
        [Display(Name = "Identity")]
        public string Guardian_Identity { get; set; }
        [Required]
        [Display(Name = "Relationship")]
        public string Relationship { get; set; }
        [Required]
        [Display(Name = "Cellphone")]
        public string Guardian_CellPhone { get; set; }
        [Required]
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Guardian_Address { get; set; }
        [Required]
        [Display(Name = "Code")]
        public string Guardian_Address_Code { get; set; }

        //School Attributes
        [Required]
        [Display(Name = "School Name")]
        public string School_Name { get; set; }
        [Required]
        [Display(Name = "Center")]
        public string School_Center { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        public string School_ContactNumber { get; set; }
        [Required]
        [Display(Name = "City/Towm")]
        public string School_City_Town { get; set; }
        public List<SubjectViewModel> Subjects { get; set; }
        
    }
}
