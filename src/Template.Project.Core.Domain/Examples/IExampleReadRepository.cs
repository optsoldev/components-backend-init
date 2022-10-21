using System;
using Optsol.Components.Domain.Data;

namespace Template.Project.Core.Domain.Examples
{
    public interface IExampleReadRepository : IReadRepository<Example, Guid>
    {
    }
}
