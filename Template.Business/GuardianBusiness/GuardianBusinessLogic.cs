using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Core.Entities;
using Template.Model.GuardianModels;
using Template.Model.StudentModels;
using Template.Service.GuardianService;

namespace Template.Business.GuardianBusiness
{
    public class GuardianBusinessLogic : IGuardianBusinessLogic
    {
        private readonly IGuardianRepository _guardianrepository;
        public GuardianBusinessLogic(IGuardianRepository guardianrepository)
        {
            _guardianrepository = guardianrepository;
        }
        /// <summary>
        /// Insert guardian
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Identity</returns>
        public async Task<string> InsertGuardianAsync(StudentModel model)
        {
            var guardian = new Guardian
            {
                Identity = model.Guardian_Identity,
                Title = model.Guardian_Title.ToString(),
                FirstName = model.Guardian_FirstName,
                Relationship = model.Relationship,
                Address = model.Guardian_Address,
                LastName=model.Guardian_Surname,
                Code = model.Guardian_Address_Code,
                CellPhone = model.Guardian_CellPhone,
                Occupation = model.Occupation
            };
            await _guardianrepository.InsertguardianAsync(guardian);

            return guardian.Identity;
        }
    }
}
