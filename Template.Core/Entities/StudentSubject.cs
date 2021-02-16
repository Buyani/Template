using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Entities
{
    public class StudentSubject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Subject Course { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual Student Student { get; set; }
    }
}
