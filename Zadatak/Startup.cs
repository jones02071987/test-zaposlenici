using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Zadatak.Data;
using Zadatak.Models;
using Zadatak.Services;

namespace Zadatak
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;"));

            services.AddScoped<IZaposleniciRepository, ZaposeniciRepository>();
            services.AddTransient<DbSeeder>();
            services.AddTransient<AgeCalculator>();
            services.AddTransient<DateResolver>();

            services.AddMvc(opts =>
            {
                // apply [ValidateModel] globally
                opts.Filters.Add(typeof(ValidateModelAttribute));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //Mapper.Initialize(cfg => cfg.CreateMap<Zaposlenik, ZaposlenikDto>()
            //.ConstructUsingServiceLocator()
            //.ForMember(dest => dest.DatumRodjenja, opt => opt.ResolveUsing<DateResolver>()));
        }
    }
}