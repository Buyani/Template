using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;

namespace Template.Service.SubjectService
{
    public class SubjectRepository :Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(MatricExcellenceDbContext context)
        : base(context)
            {
            }

        public async Task DeleteSubjectAsync(Subject subject)
        {
            await DeleteAsync(subject);
        }
        public async Task<List<Subject>> GetAllSubjectAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Subject> GetSubjectByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(p=>p.Id.Equals(id));;
        }
        public async Task InsertSubjectAsync(Subject subject)
        {
            await AddAsync(subject);
        }
        public async Task UpdatteSubject(Subject model)
        {
            await UpdateAsync(model);
        }
    }
}
