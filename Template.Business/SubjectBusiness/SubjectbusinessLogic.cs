using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.SubjectModels;
using Template.Service.SubjectService;

namespace Template.Business.SubjectBusiness
{
    public class SubjectbusinessLogic: ISubjectbusinessLogic
    {
        private readonly ISubjectRepository _subjectservice;
        public SubjectbusinessLogic(ISubjectRepository subjectservice)
        {
            _subjectservice = subjectservice;
        }

        public async Task InsertSubject(SubjectModel model)
        {
            await _subjectservice.InsertSubjectAsync(Convert(model));
        }
        public Subject Convert(SubjectModel model)
        {
            return new Subject
            {
                Name=model.Name
            };
        }
    }
}
