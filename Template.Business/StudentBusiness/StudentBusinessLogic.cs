using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.StudentModels;
using Template.Service.StudentService;

namespace Template.Business.StudentBusiness
{
    public class StudentBusinessLogic: IStudentBusinessLogic
    {
        private readonly IStudentRepository _studentservice;
        public StudentBusinessLogic(IStudentRepository studentservice)
        {
            _studentservice = studentservice;
        }

        public async Task InsertStudent(StudentModel model)
        {
            await _studentservice.InsertStudentAsync(Convert(model));
        }
        public Student Convert(StudentModel model)
        {
            return new Student
            {
                Identity = model.Identity,
                FirstName = model.FirstName,
                Surname = model.Surname
            };
        }
    }
}
