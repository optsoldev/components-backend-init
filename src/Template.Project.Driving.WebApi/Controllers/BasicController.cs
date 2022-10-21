using Microsoft.AspNetCore.Mvc;
using Optsol.Components.Service.Controllers;
using Optsol.Components.Service.Responses;
using Template.Project.Core.Application.Examples;

namespace Template.Project.Driving.WebApi.Controllers
{
    public class BasicController : ApiControllerBase
    {
        public BasicController(IResponseFactory responseFactory)
            : base(responseFactory)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.CompletedTask;

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetId([FromRoute] Guid id)
        {
            await Task.CompletedTask;

            return Ok(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ExampleViewModel model)
        {
            await Task.CompletedTask;

            return Ok(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ExampleViewModel model)
        {
            await Task.CompletedTask;

            return Ok(model);
        }

        [HttpPatch]
        public async Task<IActionResult> Patch([FromBody] ExampleViewModel model)
        {
            await Task.CompletedTask;

            return Ok(model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await Task.CompletedTask;

            return Ok(id);
        }
    }
}
