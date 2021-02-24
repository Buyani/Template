using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.SchoolService
{
    public interface ISchoolRepository
    {
        Task<School> GetSchoolByIdAsync(int id);
        Task<List<School>> GetAllSchoolsAsync();
        Task UpdatteSchool(School formerschool);
        Task InsertSchoolAsync(School formerschool);
        Task DeleteSchoolAsync(School formerschool);
    }
}
