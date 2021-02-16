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
        public async Task DeleteGuardianAsync(Guardian guardian)
        {
            await DeleteAsync(guardian);
        }
        public async Task<List<Guardian>> GetAllGuardiansAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Guardian> GetGuardianByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task InsertGuardianAsync(Guardian guardian)
        {
            await AddAsync(guardian);
        }
        public async Task UpdateGuardianAsync(Guardian guardian)
        {
            await UpdateAsync(guardian);
        }
    }
}
