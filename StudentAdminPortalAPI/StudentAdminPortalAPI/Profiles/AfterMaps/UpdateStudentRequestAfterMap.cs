using AutoMapper;
using StudentAdminPortalAPI.DomainModels;
using Models = StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentRequest, Models.Student>
    {
        public void Process(UpdateStudentRequest source, Models.Student destination, ResolutionContext context)
        {
            destination.Address = new Models.Address()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddres = source.PostalAddres,
            };
        }
    }
}
