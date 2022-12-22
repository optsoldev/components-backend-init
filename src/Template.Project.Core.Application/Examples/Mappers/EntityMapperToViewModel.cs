using AutoMapper;
using Template.Project.Core.Domain.Examples;

namespace Template.Project.Core.Application.Examples.Mappers;

public class EntityMapperToViewModel : Profile
{
    public EntityMapperToViewModel()
    {
        CreateMap<ExampleRequestModel, Example>().ConstructUsing(x => new Example());
        CreateMap<Example, ExampleResponseModel>();
    }
}
