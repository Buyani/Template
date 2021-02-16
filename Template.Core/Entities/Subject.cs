using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
