using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.SchoolModels;
using Template.Model.StudentModels;

namespace Template.Business.FormerSchoolBusiness
{
    public interface ISchoolBusinessLogic
    {
        Task<int> InsertSchoolAsync(StudentModel model);
    }
}
