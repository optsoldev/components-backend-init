using Microsoft.EntityFrameworkCore;
using Optsol.Components.Infra.Data;
using Template.Project.Driven.Infra.Data.EntityConfigs;

namespace Template.Project.Driven.Infra.Data.Context
{
    public class TemplateContext : CoreContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Configuring context

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ExampleConfiguration());
        }
    }
}
