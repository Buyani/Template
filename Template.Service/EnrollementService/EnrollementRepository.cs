using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;

namespace Template.Service.EnrollementService
{
    public class EnrollementRepository : Repository<Enrollement>, IEnrollementRepository
    {
        public EnrollementRepository(MatricExcellenceDbContext context)
            : base(context)
        {
        }
        public async Task DeleteEnrollementAsync(Enrollement enrollement)
        {
            await DeleteAsync(enrollement);
        }
        public async Task<List<Enrollement>> GetAllEnrollementAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Enrollement> GetEnrollementByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task InsertEnrollementAsync(Enrollement enrollement)
        {
            await AddAsync(enrollement);
        }
        public async Task UpdateEnrollementAsync(Enrollement enrollement)
        {
            await UpdateAsync(enrollement);
        }
    }
}
