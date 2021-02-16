using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;

namespace Template.Service.FormerSchoolService
{
    public class FormerSchoolRerpository : Repository<FormerSchool>, IFormerSchoolRepository
    {
        public FormerSchoolRerpository(MatricExcellenceDbContext context)
            : base(context)
        {
        }
        public async Task DeleteFormerSchoolAsync(FormerSchool formerschool)
        {
            await DeleteAsync(formerschool);
        }
        public async Task<List<FormerSchool>> GetAllFormerSchoolsAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<FormerSchool> GetFormerSchoolByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task InsertFormerSchoolAsync(FormerSchool formerschool)
        {
            await AddAsync(formerschool);
        }
        public async Task UpdatteFormerSchool(FormerSchool formerschool)
        {
            await UpdateAsync(formerschool);
        }
    }
}
