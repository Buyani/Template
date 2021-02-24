using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;

namespace Template.Service.StudentService
{
    public class StudentRepository: Repository<Student>, IStudentRepository
    {
        public StudentRepository(MatricExcellenceDbContext context)
            : base(context)
        {
        }

        public async Task DeleteStudentAsync(Student student)
        {
            await DeleteAsync(student);
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(string id)
        {
            return await GetAll()
                .Include(p=>p.Enrollements)
                .Include(p=>p.Payments)
                .FirstOrDefaultAsync(p => p.Identity.Equals(id));
        }
        public async Task InsertStudentAsync(Student student)
        {
            await AddAsync(student);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            await UpdateAsync(student);
        }
    }
}
