using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data;
using AllNews.Data.Interfaces;
using AllNews.Data.Repositores;
using AllNews.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
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
            services.AddIdentity<AppUser, AppRole>(options =>
            {

                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = true;
            }).AddEntityFrameworkStores<AllNewsDbContext>();



            services.AddDbContext<AllNewsDbContext>(
            options => 
                {
                    options.UseLazyLoadingProxies();
                    options.UseSqlServer(this.Configuration.GetConnectionString("AllNewsConnetion"));
                }
            );

            services.AddLocalization(options => options.ResourcesPath = "LangResources");

            services.AddMvc().AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix, options =>
            {
                options.ResourcesPath = "LangResources";
            }).AddDataAnnotationsLocalization(options =>
            {
                options.DataAnnotationLocalizerProvider = (x, y) => y.Create(typeof(ShareLangResource));
            });



            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<SignInManager<AppUser>>();
            services.AddScoped<UserManager<AppUser>>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            var myCultures = new List<CultureInfo>()
            {
                new CultureInfo("en-UK"),
                new CultureInfo("fa-IR"),
                new CultureInfo("ar-SA"),
            };
            var myOptions = new RequestLocalizationOptions()
            {
                DefaultRequestCulture=new RequestCulture("ar-SA"),
                SupportedCultures= myCultures,
                SupportedUICultures= myCultures,
                RequestCultureProviders=new List<IRequestCultureProvider>()
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                }
            };
            app.UseRequestLocalization(myOptions);

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
