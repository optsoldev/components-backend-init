using Template.Project.Core.Application.Mappers;
using Template.Project.Core.Application.Services;
using Template.Project.Core.Domain.Services;
using Template.Project.Driven.Infra.Data.Context;
using Template.Project.Driven.Infra.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection");
            
builder.Services.AddHealthChecks(builder.Configuration);

builder.Services.AddContext<TemplateContext>(options =>
{
    options
        .ConfigureConnectionString(connectionString.Value)
        .ConfigureMigrationsAssemblyName("Template.Project.Driven.Infra")
        .EnabledLogging();

});

builder.Services.AddDomainService<IExampleDomainService, ExampleDomainService>("Template.Project.Core.Domain", "Template.Project.Driven.Infra");
builder.Services.AddApplications(options =>
{
    options.ConfigureServices<IExampleServiceApplication, ExampleServiceApplication>("Template.Project.Core.Application");
    options.ConfigureAutoMapper<ViewModelToEntityMapper>();
});

builder.Services.AddDomainNotifications();
builder.Services.AddServices();

//builder.Services.AddCors(builder.Configuration);
//builder.Services.AddSecurity(builder.Configuration);
//builder.Services.AddSwagger(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

//app.UseSecurity(builder.Configuration);

//app.UseCors(builder.Configuration);

//app.UseSwagger(builder.Configuration, app.Environment.IsDevelopment());

app.UseHealthChecks(builder.Configuration);

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Example API Started.");
    });

    endpoints.MapControllers();
});