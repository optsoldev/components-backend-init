using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optsol.Components.Infra.Data;
using System;
using Template.Project.Domain.Entities;

namespace Template.Project.Infra.Data.EntityConfigs
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
