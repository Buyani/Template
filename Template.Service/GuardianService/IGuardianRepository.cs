using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.GuardianService
{
    public interface IGuardianRepository
    {
        Task<Guardian> GetGuardianByIdAsync(int id);
        Task<List<Guardian>> GetAllGuardiansAsync();
        Task InsertGuardianAsync(Guardian guardian);
        Task UpdateGuardianAsync(Guardian guardian);
        Task DeleteGuardianAsync(Guardian guardian);
    }
}
