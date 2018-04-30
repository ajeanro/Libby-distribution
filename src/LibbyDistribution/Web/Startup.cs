using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web.Data;
using Web.Models;
using Web.Services;
using Infrastructure;
using ApplicationCore.Interfaces;

namespace Web
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
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<CustomerContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
            services.AddScoped<ICategoryRepository, CategoryRepositoryEf>();
            services.AddScoped<IDriverRepository, DriverRepositoryEf>();
            services.AddScoped<IEquipmentRepository, EquipmentRepositoryEf>();
            services.AddScoped<IEquipmentIssueRepository, IEquipmentIssueRepository>();
            services.AddScoped<IProductRepository, ProductRepositoryEf>();
            services.AddScoped<IRetailCustomerRepository, RetailCustomerRepositoryEf>();
            services.AddScoped<IRetailOrderDetailRepository, RetailOrderDetailRepositoryEf>();
            services.AddScoped<IRetailOrderRepository, RetailOrderRepositoryEf>();
            services.AddScoped<ISalesAgentRepository, SalesAgentRepositoryEf>();
            services.AddScoped<IWholesaleCustomerRepository, WholesaleCustomerRepositoryEf>();
            services.AddScoped<IWholesaleOrderDetailRepository, WholesaleOrderDetailRepositoryEf>();
            services.AddScoped<IWholesaleOrderRepository, WholesaleOrderRepositoryEf>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
