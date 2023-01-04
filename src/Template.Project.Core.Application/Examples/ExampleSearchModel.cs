using System;
using System.Linq;
using System.Linq.Expressions;
using Optsol.Components.Application.DataTransferObjects;
using Optsol.Components.Infra.Data.Pagination;
using Optsol.Components.Shared.Extensions;
using Template.Project.Core.Domain.Examples;

namespace Template.Project.Core.Application.Examples;

public class ExampleSearchModel : ISearch<Example>, IOrderBy<Example>
{
    public Expression<Func<Example, bool>> GetSearcher()
    {
        var expression = PredicateBuilderExtensions.PredicateBuilder.True<Example>();
        return expression;
    }

    public Func<IQueryable<Example>, IOrderedQueryable<Example>> GetOrderBy()
    {
        return q => q.OrderBy(x => x.Id);
    }
}