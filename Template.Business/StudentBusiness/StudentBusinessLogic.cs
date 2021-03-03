using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.GuardianModels;
using Template.Model.PaymentModels;
using Template.Model.SchoolModels;
using Template.Model.StudentModels;
using Template.Model.SubjectModels;
using Template.Service.EnrollementService;
using Template.Service.GuardianService;
using Template.Service.SchoolService;
using Template.Service.StudentService;
using Template.Service.SubjectService;

namespace Template.Business.StudentBusiness
{
    public class StudentBusinessLogic: IStudentBusinessLogic
    {
        private readonly IStudentRepository _studentservice;
        private readonly ISchoolRepository _schoolservice;
        private readonly IGuardianRepository _guardianservice;
        private readonly ISubjectRepository _subjectservice;

        public StudentBusinessLogic(IStudentRepository studentservice , ISchoolRepository schoolservice, 
            IGuardianRepository guardianservice, ISubjectRepository subjectservice)
        {
            _studentservice = studentservice;
            _schoolservice = schoolservice;
            _guardianservice = guardianservice;
            _subjectservice = subjectservice;
        }
        public async Task<string> InsertStudentAsync(StudentModel model, string GuardianIdentity,int SchoolId)
        {

            var student = new Student
            {
                Identity = model.Identity,
                Guradian_Identity=GuardianIdentity,
                SchoolId= SchoolId,
                Title=model.Title.ToString(),
                FirstName = model.FirstName,
                Email = model.Email,
                TelephoneNumber = model.TelephoneNumber,
                Address = model.Address,
                Code=model.Code,
                CellNumber = model.CellNumber,
                Nationality = model.Nationality,
                Surname = model.Surname
            };
            await _studentservice.InsertStudentAsync(student);
            return student.Identity;
        }
        public async Task<List<StudentViewModel>> AllStudentsAsync()
        {
            var studentlist = await _studentservice.GetAllStudentsAsync();
            return studentlist.Select(p => new StudentViewModel
            {
                FirstName = p.FirstName,
                Identity = p.Identity,
                Surname = p.Surname,
                CellNumber = p.CellNumber,
                Email = p.Email,
                DateCreated = p.CreatedAt,
               
            }).ToList();
        }
        /// <summary>
        /// gets students by identity
        /// </summary>
        /// <param name="Identity"></param>
        /// <returns></returns>
        public async Task<StudentViewModel> GetStudentByIdentityAsync(string Identity)
        {
            var student =await  _studentservice.GetStudentByIdAsync(Identity);
            var studentdetails = new StudentViewModel
            {
                Address = student.Address,
                CellNumber = student.CellNumber,
                Code = student.Code,
                DateCreated = student.CreatedAt,
                Email = student.Email,
                FirstName = student.FirstName,
                Surname = student.Surname,
                TelephoneNumber = student.TelephoneNumber,
                Identity = student.Identity,
                Nationality = student.Nationality,
                Payments = student.Payments.Select(p => new PaymentViewModel
                {
                    Id = p.Id,
                    Amount = p.Amount,
                    DateCreated = p.DateCreated,
                    Identity = p.StudentIdentity,
                    Month = p.Month

                }).ToList(),
                Enrollements =await  GetStudentSubjectsAsync(student.Enrollements),

                Parent = await GetStudentGuradrianAsync(student.Guradian_Identity),
                School=await GetStudentSchoolAsync(student.SchoolId)
            };
            return  studentdetails;
        }
        /// <summary>
        /// gets students guardian
        /// </summary>
        /// <param name="GuardianIdentity"></param>
        /// <returns></returns>
        public async Task<GuardianViewModel> GetStudentGuradrianAsync(string GuardianIdentity)
        {
            var parent= await _guardianservice.GetguardianByIdAsync(GuardianIdentity);

            return new GuardianViewModel
            {
                FirstName=parent.FirstName,
                CellPhone=parent.CellPhone,
                LastName=parent.LastName,
                Occupation=parent.Occupation,
                Relationship=parent.Relationship
            };
        }
        /// <summary>
        /// gets student school
        /// </summary>
        /// <param name="SchoolId"></param>
        /// <returns></returns>
        public async Task<SchoolsViewModel> GetStudentSchoolAsync(int SchoolId)
        {
            var school = await _schoolservice.GetSchoolByIdAsync(SchoolId);

            return new SchoolsViewModel
            {
                Id = school.Id,
                Name = school.Name,
                Center = school.Center,
                ContactNumber = school.ContactNumber,
                City_Town = school.City_Town
            };

        }
        public async Task<List<EnrollementViewModel>> GetStudentSubjectsAsync(ICollection<Enrollement> enrollements)
        {
            var list = new List<EnrollementViewModel>();
            foreach(var enrol in enrollements)
            {
                var subject = await _subjectservice.GetSubjectByIdAsync(enrol.SubjectId);
                list.Add(
                    new EnrollementViewModel
                    {
                        Id = enrol.Id,
                        Name = subject.Name
                    });                   
            }
            return list;
        }

    }
}
