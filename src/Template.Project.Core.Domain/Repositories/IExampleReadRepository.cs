using Optsol.Components.Domain.Data;
using System;
using Template.Project.Core.Domain.Entities;

namespace Template.Project.Core.Domain.Repositories
{
    public interface IExampleReadRepository : IReadRepository<Example, Guid>
    {
    }
}
