using AutoMapper;
using Optsol.Components.Infra.Data.Pagination;
using Template.Project.Core.Domain.Examples;

namespace Template.Project.Core.Application.Examples.Mappers;

public class ExampleMapper : Profile
{
    public ExampleMapper()
    {
        CreateMap<ExampleRequestModel, Example>().ConstructUsing(x => new Example());
        CreateMap<Example, ExampleResponseModel>();
        CreateMap<SearchResult<Example>, SearchResult<ExampleResponseModel>>();
    }
}
