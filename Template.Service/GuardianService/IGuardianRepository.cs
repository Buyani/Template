using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.GuardianService
{
    public interface IGuardianRepository
    {
        Task<Guardian> GetguardianByIdAsync(string id);
        Task<List<Guardian>> GetAllguardiansAsync();
        Task InsertguardianAsync(Guardian guardian);
        Task UpdateguardianAsync(Guardian guardian);
        Task DeleteguardianAsync(Guardian guardian);
    }
}
