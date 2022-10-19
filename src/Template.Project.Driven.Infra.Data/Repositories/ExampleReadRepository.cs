using Microsoft.Extensions.Logging;
using Optsol.Components.Infra.Data;
using System;
using Template.Project.Core.Domain.Entities;
using Template.Project.Core.Domain.Repositories;

namespace Template.Project.Driven.Infra.Data.Repositories
{
    public class ExampleReadRepository : Repository<Example, Guid>, IExampleReadRepository
    {
        public ExampleReadRepository(CoreContext context, ILoggerFactory logger)
            : base(context, logger)
        {
        }
    }
}
