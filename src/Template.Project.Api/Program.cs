using Microsoft.Extensions.Hosting;
using Optsol.Components.Service.Programs;

namespace Template.Project.Api
{
    public class Program : BaseProgram
    {
        public static void Main(string[] args) => Start(CreateHostBuilder(args));

        public static IHostBuilder CreateHostBuilder(string[] args) => CreateHostBuilder<Startup>(args);
    }
}
