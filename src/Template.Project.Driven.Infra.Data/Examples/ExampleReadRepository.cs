using System;
using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;
using Template.Project.Core.Domain.Examples;

namespace Template.Project.Driven.Infra.Data.Examples
{
    public class ExampleReadRepository : Repository<Example, Guid>, IExampleReadRepository
    {
        public ExampleReadRepository(CoreContext context, ILoggerFactory logger)
            : base(context, logger)
        {
        }
    }
}
