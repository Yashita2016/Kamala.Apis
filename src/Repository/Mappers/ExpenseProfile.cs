using AutoMapper;
using Contract.Models;
using DataAccess.Models;

namespace Repository.Mappers
{
    public class ExpenseProfile : Profile
    {
        public ExpenseProfile()
        {
            CreateMap<ExpenseDto, Expense>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.ExpenseType))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date));

            CreateMap<TypeDto, DataAccess.Models.Type>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Expense, ExpenseDto>()
                .ForMember(dest => dest.ExpenseType, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date));

            CreateMap<DataAccess.Models.Type, TypeDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        }
    }
}
