using Optsol.Components.Application.Services;
using Optsol.Components.Service.Controllers;
using Optsol.Components.Service.Responses;
using Template.Project.Core.Application.Models;
using Template.Project.Core.Domain.Entities;

namespace Template.Project.Driving.WebApi.Controllers
{
    public class ComponentsController : ApiControllerBase<Example, ExampleViewModel, ExampleViewModel, ExampleViewModel>
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
