using Template.Project.Core.Application.Examples;
using Template.Project.Core.Application.Examples.Mappers;
using Template.Project.Core.Domain.Examples;
using Template.Project.Driven.Infra.Data.Context;
using Template.Project.Driven.Infra.Data.Examples;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection");
            
builder.Services.AddHealthChecks(builder.Configuration);

builder.Services.AddContext<TemplateContext>(options =>
{
    options
        .ConfigureConnectionString(connectionString.Value)
        .ConfigureMigrationsAssemblyName("Template.Project.Driven.Infra")
        .EnabledLogging()
        .ConfigureRepositories<IExampleReadRepository, ExampleReadRepository>(
            typeof(IExampleReadRepository).Assembly.FullName,
            typeof(ExampleReadRepository).Assembly.FullName);

});

builder.Services.AddDomainService<IExampleDomainService, ExampleDomainService>(typeof(IExampleDomainService).Assembly.FullName, 
    typeof(ExampleDomainService).Assembly.FullName);

builder.Services.AddApplications(options =>
{
    options.ConfigureServices<IExampleServiceApplication, ExampleServiceApplication>(typeof(IExampleServiceApplication).Assembly.FullName);
    options.ConfigureAutoMapper<ViewModelToEntityMapper>();
});

builder.Services.AddDomainNotifications();
builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseHealthChecks(builder.Configuration);

app.MapControllers();

app.Run();