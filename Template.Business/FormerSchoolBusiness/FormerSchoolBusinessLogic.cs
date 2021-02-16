using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.FormerSchoolModels;
using Template.Service.FormerSchoolService;

namespace Template.Business.FormerSchoolBusiness
{
    public class FormerSchoolBusinessLogic : IFormerSchoolBusinessLogic
    {
        private readonly IFormerSchoolRepository _repositopry;
        public FormerSchoolBusinessLogic(IFormerSchoolRepository repositopry)
        {
            _repositopry = repositopry;
        }
        public async Task InsertStudent(FomerSchoolModel model)
        {
            await _repositopry.InsertFormerSchoolAsync(Convert(model));
        }
        public FormerSchool Convert(FomerSchoolModel model)
        {
            return new FormerSchool
            {
                Name=model.Name,
                ContactNumber=model.ContactNumber,
                City_Town=model.City_Town,
                Center=model.Center,
                CreatedAt=model.CreatedAt
            };
        }
    }
}
