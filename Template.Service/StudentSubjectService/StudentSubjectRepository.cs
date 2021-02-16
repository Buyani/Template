using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Data;
using Template.Service.StudentSubjectService;

namespace Template.Service.StudentSubjectService
{
    public class StudentSubjectRepository : Repository<StudentSubject>, IStudentSubjectRepository
    {
        public StudentSubjectRepository(MatricExcellenceDbContext context)
            : base(context)
        {
        }
        public async Task DeleteStudentSubjectAsync(StudentSubject studentsubject)
        {
            await DeleteAsync(studentsubject);
        }
        public async Task<List<StudentSubject>> GetAllStudentSubjectsAsync()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<StudentSubject> GetStudentSubjectByIdAsync(int id)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task InsertStudentSubjectAsync(StudentSubject studentsubject)
        {
            await AddAsync(studentsubject);
        }
        public async Task UpdateStudentSubjectAsync(StudentSubject studentsubject)
        {
            await UpdateAsync(studentsubject);
        }
    }
}
