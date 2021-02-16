
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;
using Template.Model.StudentModels;

namespace Template.Data.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Student, StudentModel>();
            CreateMap<Student, StudentViewModel>();

        }
    }
}
