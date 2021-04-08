using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Template.Project.Application.Mappers;
using Template.Project.Application.Services;
using Template.Project.Domain.Repositories;
using Template.Project.Domain.Services;
using Template.Project.Infra.Data.Context;
using Template.Project.Infra.Data.Repositories;
using Template.Project.Infra.Services;

namespace Template.Project.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Environment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = this.Configuration.GetSection("ConnectionStrings:DefaultConnection");

            services.AddContext<TemplateContext>(options =>
            {
                options
                    .ConfigureConnectionString(connectionString.Value)
                    .ConfigureMigrationsAssemblyName("Template.Project.Infra")
                    .EnabledLogging();

            });
            services.AddRepository<IExampleReadRepository, ExampleReadRepository>("Template.Project.Domain", "Template.Project.Infra");
            services.AddDomainService<IExampleDomainService, ExampleDomainService>("Template.Project.Domain", "Template.Project.Infra");
            services.AddApplications<IExampleServiceApplication, ExampleServiceApplication>("Template.Project.Application");
            services.AddDomainNotifications();
            services.AddServices();

            services.AddCors(Configuration);
            services.AddSecurity(Configuration);
            services.AddSwagger(Configuration);

            services.AddAutoMapper(typeof(ViewModelToEntityMapper));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSecurity(Configuration);

            app.UseCors(Configuration);

            app.UseSwagger(Configuration, env.IsDevelopment());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Example API Started.");
                });

                endpoints.MapControllers();
            });
        }
    }
}
