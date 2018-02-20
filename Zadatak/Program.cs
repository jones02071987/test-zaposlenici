using AutoMapper;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Zadatak.Data;
using Zadatak.Models;
using Zadatak.Services;

namespace Zadatak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var dbSeeder = services.GetService<DbSeeder>();
                    dbSeeder.Seed();
                }
                catch (System.Exception e)
                {
                    throw new System.Exception("DbSeeder not resolved");
                }
                Mapper.Initialize(cfg => cfg.CreateMap<Zaposlenik, ZaposlenikDto>()
                    .ForMember(dest => dest.DatumRodjenja,
                    opt => opt.ResolveUsing(new DateResolver(new AgeCalculator()))));
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}