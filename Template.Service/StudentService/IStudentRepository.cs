using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;

namespace Template.Service.StudentService
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByIdAsync(string id);
        Task<List<Student>> GetAllStudentsAsync();
        Task InsertStudentAsync(Student student);
        Task UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(Student student);
    }
}
