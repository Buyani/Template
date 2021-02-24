
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;
using Template.Model.SchoolModels;
using Template.Model.StudentModels;
using Template.Model.SubjectModels;

namespace Template.Data.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {

            //Student, StudentViewModel and StudentModel Mappings


            //CreateMap<StudentModel, Student>()
            //    .ForMember(c => c.StudentSubjects, option => option.Ignore())
            //    .ForMember(c => c.Guradian, option => option.Ignore())
            //    .ForMember(c => c.FormerSchool, option => option.Ignore());

            //CreateMap<Student, StudentViewModel>();
            //CreateMap<StudentViewModel, Student>();

            ////Subject and SubjectViewModel
            //CreateMap<Subject, SubjectViewModel>();
            //CreateMap<SubjectModel, Subject>();

            ////School,SchoolViewModel and SchoolModel Mappings
            //CreateMap<FormerSchool, SchoolsViewModel>();
            //CreateMap<SchoolModel, FormerSchool>();

        }
    }
}
