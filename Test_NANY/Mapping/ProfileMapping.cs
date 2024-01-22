using AutoMapper;
using Test_NANY.Data.Models;
using Test_NANY.Data.ViewModels;

namespace Test_NANY.Mapping
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<ChildProfile, ChildViewModel>()
                .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion.ToString()))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()));
           
            CreateMap<NanyProfile, NanyViewModel>()
                           .ForMember(dest => dest.NReligion, opt => opt.MapFrom(src => src.Religion.ToString()))
                       .ForMember(dest => dest.NGender, opt => opt.MapFrom(src => src.Gender.ToString()));

            CreateMap<Shift, ShiftViewModel>();
            CreateMap<Registration, RegistrationViewModel>();


        }
    }
}
