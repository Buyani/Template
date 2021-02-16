using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.FormerSchoolService
{
    public interface IFormerSchoolRepository
    {
        Task<FormerSchool> GetFormerSchoolByIdAsync(int id);
        Task<List<FormerSchool>> GetAllFormerSchoolsAsync();
        Task UpdatteFormerSchool(FormerSchool formerschool);
        Task InsertFormerSchoolAsync(FormerSchool formerschool);
        Task DeleteFormerSchoolAsync(FormerSchool formerschool);
    }
}
