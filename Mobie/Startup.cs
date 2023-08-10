using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MobileShop.Models;
using sell.Models;
using System;

namespace MobileShop
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
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(context => context.UseSqlServer(Configuration.GetConnectionString("MobileShopDBConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddScoped<ICategory, SQLCategoryRepository>();
            services.AddScoped<ISubCategory, SQLSubCategoryRepository>();
            services.AddScoped<IProduct, SQLProductRepository>();
            services.AddScoped<IRegistration, SQLUserRepository>();
            services.AddScoped<Ilike, SQLLikes>();
            services.AddScoped<IUserHistory, SQLHistoryUser>();
            #region Setting Identity Password Option
            services.Configure<IdentityOptions>(option =>
 {
     option.Password.RequiredLength = 6;
     option.Password.RequireNonAlphanumeric = false;
 });
            #endregion

            services.AddSession(options =>
            {
                options.Cookie.Name = ".MyApp.Session";
                options.IdleTimeout = TimeSpan.FromHours(3);
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=UserHome}/{action=Index}/{id?}");
            });
        }
    }
}
