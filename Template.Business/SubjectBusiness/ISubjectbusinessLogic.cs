﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Model.SubjectModels;

namespace Template.Business.SubjectBusiness
{
    public interface ISubjectbusinessLogic
    {
        Task InsertSubject(SubjectModel model);
        Task<List<SubjectViewModel>> AllSubjects();
    }
}
