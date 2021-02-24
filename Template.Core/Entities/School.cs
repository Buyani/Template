using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Center { get; set; }
        public string ContactNumber { get; set; }
        public string City_Town { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Student> Students { get; set; }
    }
}
