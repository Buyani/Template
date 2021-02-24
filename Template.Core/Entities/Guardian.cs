using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Template.Core.Entities
{
    public class Guardian
    {
        [Key]
        public string Identity { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }
        public string CellPhone { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public Student Student { get; set; }
    }
}
