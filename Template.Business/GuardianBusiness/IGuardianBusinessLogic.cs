using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.GuardianModels;
using Template.Model.StudentModels;

namespace Template.Business.GuardianBusiness
{
    public interface IGuardianBusinessLogic
    {
        Task<string> InsertGuardianAsync(StudentModel model);
    }
}
