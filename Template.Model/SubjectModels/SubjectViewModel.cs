using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Model.SubjectModels
{
    public class SubjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool CheckboxAnswer { get; set; }
    }
}
