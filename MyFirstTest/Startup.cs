using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyFirstTest.Models;

namespace MyFirstTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //_____________________________________________________________________________
        public IConfiguration Configuration { get; }
        //_____________________________________________________________________________
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BusinessContext>(options => options.UseSqlServer(connection));
            //_________________________________
            services.AddControllersWithViews();
        }
        //_____________________________________________________________________________
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //_________________________________
            app.UseRouting();
            app.UseStaticFiles();
            //_________________________________
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=CRUD}/{action=AllCustomers}/{id?}");
            });
        }
        //_____________________________________________________________________________
    }
}
