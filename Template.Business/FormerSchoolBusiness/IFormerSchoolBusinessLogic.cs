using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.FormerSchoolModels;

namespace Template.Business.FormerSchoolBusiness
{
    public interface IFormerSchoolBusinessLogic
    {
        Task InsertStudent(FomerSchoolModel model);
    }
}
