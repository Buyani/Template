using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.SchoolModels;
using Template.Model.StudentModels;
using Template.Service.SchoolService;

namespace Template.Business.FormerSchoolBusiness
{
    public class SchoolBusinessLogic : ISchoolBusinessLogic
    {
        private readonly ISchoolRepository _schoolrepositopry;
        public SchoolBusinessLogic(ISchoolRepository schoolrepositopry)
        {
            _schoolrepositopry = schoolrepositopry;
        }
        /// <summary>
        /// Insert a new school
        /// </summary>
        /// <param name="model"></param>
        /// <returns>school Id</returns>
        public async Task<int> InsertSchoolAsync(StudentModel model)
        {
            var school = new School
            {
                Center = model.School_Center,
                City_Town = model.School_City_Town,
                ContactNumber = model.School_ContactNumber
            };
            await _schoolrepositopry.InsertSchoolAsync(school);
            return school.Id;
        }
        /// <summary>
        /// get list of all schools
        /// </summary>
        /// <returns></returns>
        public async Task<List<SchoolsViewModel>> AllSchoolsAsync()
        {
            var schoollist = await _schoolrepositopry.GetAllSchoolsAsync();
            return schoollist.Select(p => new SchoolsViewModel { Name = p.Name, Id = p.Id, Center = p.Center, ContactNumber = p.ContactNumber,City_Town=p.City_Town }).ToList();
        }
    }
}
