using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.PaymentModels;
using Template.Model.StudentModels;

namespace Template.Business.StudentBusiness
{
    public interface IStudentBusinessLogic
    {
        Task<string> InsertStudentAsync(StudentModel model,string GuardianIdentity, int SchoolId);
        Task<StudentViewModel> GetStudentByIdentityAsync(string Identity);
        Task<List<StudentViewModel>> AllStudentsAsync();
    }
}
