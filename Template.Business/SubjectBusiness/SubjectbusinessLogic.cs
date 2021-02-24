using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.SubjectModels;
using Template.Service.EnrollementService;
using Template.Service.SubjectService;

namespace Template.Business.SubjectBusiness
{
    public class SubjectbusinessLogic: ISubjectbusinessLogic
    {
        private readonly ISubjectRepository _subjectservice;
        private readonly IEnrollementRepository _studentsubjectservice;
        public SubjectbusinessLogic(ISubjectRepository subjectservice, IEnrollementRepository studentsubjectservice)
        {
            _subjectservice = subjectservice;
            _studentsubjectservice = studentsubjectservice;
        }
        public async Task InsertSubject(SubjectModel model)
        {
            await _subjectservice.InsertSubjectAsync(ConvertFromSubjectModel(model));
        }
        public async Task<List<SubjectViewModel>> AllSubjects()
        {
            var subjectlist = await _subjectservice.GetAllSubjectAsync();
            return subjectlist.Select(p => new SubjectViewModel { Name = p.Name, Id = p.Id, Description = p.Description}).ToList();
        }

        private Subject ConvertFromSubjectModel(SubjectModel model)
        {
            var student = new Subject
            {
                Name = model.Name,
                Description = model.Description
            };
            return student;
        }
        //Insert Studtent Subjects
    }
}
