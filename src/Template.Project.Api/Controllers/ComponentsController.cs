using Microsoft.Extensions.Logging;
using Optsol.Components.Application.Services;
using Optsol.Components.Service.Controllers;
using Optsol.Components.Service.Responses;
using Template.Project.Application.Models;
using Template.Project.Domain.Entities;

namespace Template.Project.Api.Controllers
{
    public class ComponentsController : ApiControllerBase<Example, ExampleViewModel, ExampleViewModel, ExampleViewModel, ExampleViewModel>,
        IApiControllerBase<Example, ExampleViewModel, ExampleViewModel, ExampleViewModel, ExampleViewModel>
    {
        public ComponentsController(
            ILoggerFactory logger,
            IResponseFactory responseFactory,
            IBaseServiceApplication<Example> serviceApplication) 
            : base(logger, serviceApplication, responseFactory)
        {

        }
    }
}
