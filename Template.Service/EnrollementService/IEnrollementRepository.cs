using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.EnrollementService
{
    public interface IEnrollementRepository
    {
        Task<Enrollement> GetEnrollementByIdAsync(int id);
        Task<List<Enrollement>> GetAllEnrollementAsync();
        Task InsertEnrollementAsync(Enrollement enrollement);
        Task UpdateEnrollementAsync(Enrollement enrollement);
        Task DeleteEnrollementAsync(Enrollement enrollement);
    }
}
