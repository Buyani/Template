using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.StudentSubjectService
{
    public interface IStudentSubjectRepository
    {
        Task<StudentSubject> GetStudentSubjectByIdAsync(int id);
        Task<List<StudentSubject>> GetAllStudentSubjectsAsync();
        Task InsertStudentSubjectAsync(StudentSubject studentsubject);
        Task UpdateStudentSubjectAsync(StudentSubject studentsubject);
        Task DeleteStudentSubjectAsync(StudentSubject studentsubject);
    }
}
