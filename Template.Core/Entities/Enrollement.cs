using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Template.Core.Entities
{
    public class Enrollement
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public string StudentIdentity { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual Student Student { get; set; }
    }
}
