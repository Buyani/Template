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
        [Required(ErrorMessage = "fill in identity")]
        [Display(Name = "Identity")]
        public string Identity { get; set; }
        [Required(ErrorMessage = "fill in surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "fill in description")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "fill in nationality")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "fill in cellphone")]
        [Display(Name = "CellNumber")]
        public string CellNumber { get; set; }
        [Required(ErrorMessage = "fill in email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "fill in telephone")]
        [Display(Name = "Telephone")]
        public string TelephoneNumber { get; set; }
        [Required(ErrorMessage = "fill in address")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "fill in code")]
        [Display(Name = "Code")]
        public string Code { get; set; }
        [Required(ErrorMessage = "fill in title")]
        [Display(Name = "Title")]
        public TittleEnum Title { get; set; }
        public int SchoolId { get; set; }

        //Guardian Information
        [Required(ErrorMessage = "fill in title")]
        [Display(Name = "Title")]
        public TittleEnum Guardian_Title { get; set; }
        [Required(ErrorMessage = "fill in name")]
        [Display(Name = "First Name")]
        public string Guardian_FirstName { get; set; }
        [Required(ErrorMessage = "fill in surname")]
        [Display(Name = "Surname")]
        public string Guardian_Surname { get; set; }
        [Required(ErrorMessage = "fill in identity")]
        [Display(Name = "Identity")]
        public string Guardian_Identity { get; set; }
        [Required(ErrorMessage = "fill in relationship")]
        [Display(Name = "Relationship")]
        public string Relationship { get; set; }
        [Required(ErrorMessage = "fill in cellphone")]
        [Display(Name = "Cellphone")]
        public string Guardian_CellPhone { get; set; }
        [Required(ErrorMessage = "fill in occupation")]
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }
        [Required(ErrorMessage = "fill in address")]
        [Display(Name = "Address")]
        public string Guardian_Address { get; set; }
        [Required(ErrorMessage = "fill in code")]
        [Display(Name = "Code")]
        public string Guardian_Address_Code { get; set; }

        //School Attributes
        [Required(ErrorMessage = "fill in school name")]
        [Display(Name = "School Name")]
        public string School_Name { get; set; }
        [Required(ErrorMessage = "fill in center")]
        [Display(Name = "Center")]
        public string School_Center { get; set; }
        [Required(ErrorMessage = "fill in contact number")]
        [Display(Name = "Contact Number")]
        public string School_ContactNumber { get; set; }
        [Required(ErrorMessage = "fill in town or city")]
        [Display(Name = "City/Towm")]
        public string School_City_Town { get; set; }
        public List<SubjectViewModel> Subjects { get; set; }
        
    }
}
