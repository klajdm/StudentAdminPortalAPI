using AutoMapper;
using StudentAdminPortalAPI.DomainModels;
using Models = StudentAdminPortalAPI.Models;

namespace StudentAdminPortalAPI.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Models.Student, Student>()
                .ReverseMap();

            CreateMap<Models.Gender, Gender>()
               .ReverseMap();

            CreateMap<Models.Address, Address>()
               .ReverseMap();
        }
    }
}
