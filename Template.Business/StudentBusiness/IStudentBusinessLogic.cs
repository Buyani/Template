using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.StudentModels;

namespace Template.Business.StudentBusiness
{
    public interface IStudentBusinessLogic
    {
        Task InsertStudent(StudentModel model);
    }
}
