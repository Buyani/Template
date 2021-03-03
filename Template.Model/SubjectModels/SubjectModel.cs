using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Template.Model.SubjectModels
{
    public class SubjectModel
    {
        [Required(ErrorMessage = "fill in subject name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "fill in description")]
        public string Description { get; set; }
    }
}
