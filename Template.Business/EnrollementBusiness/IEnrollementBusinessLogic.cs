using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.SubjectModels;

namespace Template.Business.EnrollementBusiness
{
    public interface IEnrollementBusinessLogic
    {
        Task InsertChosenSubjects(List<SubjectViewModel> sujects, string studentId);

    }
}
