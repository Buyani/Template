using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.SubjectService
{
    public interface ISubjectRepository
    {
        Task<Subject> GetSubjectByIdAsync(string id);
        Task<List<Subject>> GetAllSubjectAsync();
        Task UpdatteSubject(Subject model);
        Task InsertSubjectAsync(Subject subject);
        Task DeleteSubjectAsync(Subject subject);
    }
}
