using AutoMapper;
using Core.Startup.Models;

namespace Core.Startup.Core.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Todo, TodoViewModel>();
        }
    }
}
