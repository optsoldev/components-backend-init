using Optsol.Components.Domain.Data;
using System;
using Template.Project.Domain.Entities;

namespace Template.Project.Domain.Repositories
{
    public interface IExampleReadRepository : IReadRepository<Example, Guid>
    {
    }
}
