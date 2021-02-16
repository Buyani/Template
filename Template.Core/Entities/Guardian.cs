using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Core.Entities
{
    public class Guardian
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Identity { get; set; }
        public string Relationship { get; set; }
        public string CellPhone { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Student> Students { get; set; }
    }
}
