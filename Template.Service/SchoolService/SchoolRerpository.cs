using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;

namespace Template.Service.SchoolService
{
    public class SchoolRerpository : Repository<School>, ISchoolRepository
    {
        public SchoolRerpository(MatricExcellenceDbContext context)
            : base(context)
        {
        }
        public async Task DeleteSchoolAsync(School formerschool)
        {
            await DeleteAsync(formerschool);
        }
        public async Task<List<School>> GetAllSchoolsAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<School> GetSchoolByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task InsertSchoolAsync(School formerschool)
        {
            await AddAsync(formerschool);
        }
        public async Task UpdatteSchool(School formerschool)
        {
            await UpdateAsync(formerschool);
        }
    }
}
