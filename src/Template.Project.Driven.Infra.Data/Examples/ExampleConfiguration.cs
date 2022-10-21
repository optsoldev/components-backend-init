using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optsol.Components.Infra.Data;
using Template.Project.Core.Domain.Examples;

namespace Template.Project.Driven.Infra.Data.Examples
{
    public class ExampleConfiguration : EntityConfigurationBase<Example, Guid>
    {
        public override void Configure(EntityTypeBuilder<Example> builder)
        {
            builder.ToTable("Example");

            base.Configure(builder);
        }
    }
}
