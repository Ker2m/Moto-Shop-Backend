using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using System.Timers;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();

        CreateMap<MotorCreateDto, Motor>();
        CreateMap<MotorUpdateDto, Motor>();
        CreateMap<Motor,MotorİnfoDto>();

        CreateMap<EkipmanCreateDto, Ekipman>();
        CreateMap<EkipmanUpdateDto, Ekipman>();
        CreateMap<Ekipman, EkipmanİnfoDto>();

		CreateMap<ContactCreateDto, Contact>();
		CreateMap<ContactUpdateDto, Contact>();
        CreateMap<Contact, ContactİnfoDto>();


	}
}