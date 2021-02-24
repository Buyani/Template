using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.SubjectModels;
using Template.Service.EnrollementService;

namespace Template.Business.EnrollementBusiness
{
    public class EnrollementBusinessLogic : IEnrollementBusinessLogic
    {
        private readonly IEnrollementRepository _enrollementrepository;
        public EnrollementBusinessLogic(IEnrollementRepository enrollementrepository)
        {
            _enrollementrepository = enrollementrepository;
        }
        public async Task InsertChosenSubjects(List<SubjectViewModel> sujects, string studentId)
        {
            foreach (var subject in sujects.Where(p => p.CheckboxAnswer.Equals(true)))
            {
                await _enrollementrepository.InsertEnrollementAsync(new Enrollement
                {
                    StudentIdentity=studentId,
                    SubjectId=subject.Id
                });
            }
        }
    }
}
