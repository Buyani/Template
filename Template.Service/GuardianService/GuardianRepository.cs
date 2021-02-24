using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;

namespace Template.Service.GuardianService
{
    public class GuardianRepository : Repository<Guardian>, IGuardianRepository
    {
        public GuardianRepository(MatricExcellenceDbContext context)
            : base(context)
        {
        }
        public async Task DeleteguardianAsync(Guardian guardian)
        {
            await DeleteAsync(guardian);
        }
        public async Task<List<Guardian>> GetAllguardiansAsync()
        {
            return await GetAll().Include(p => p.Student).ToListAsync();
        }
        public async Task<Guardian> GetguardianByIdAsync(string id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Identity.Equals(id));
        }
        public async Task InsertguardianAsync(Guardian guardian)
        {
            await AddAsync(guardian);
        }
        public async Task UpdateguardianAsync(Guardian guardian)
        {
            await UpdateAsync(guardian);
        }
    }
}
