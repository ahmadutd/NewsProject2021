using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using AllNewsCms.Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AllNews.Data;
using AllNews.Domain;
using AllNews.Data.Interfaces;
using AllNews.Data.Repositores;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using AllNewsCms.Web.Common;
using AllNews.Data.Service;
using AllNewsCms.Web.AntiRobot.GoogleRecaptcha;
using AllNewsCms.Web.AntiRobot.Service;

namespace AllNewsCms.Web
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
            services.AddHttpContextAccessor();
            services.AddTransient<IGoogleRecaptcha,GoogleRecaptcha>();
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

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireUppercase = false;

            }).AddDefaultUI().AddDefaultTokenProviders().AddEntityFrameworkStores<AllNewsDbContext>();

            services.AddControllersWithViews();
            services.AddRazorPages(option => {
                option.Conventions.AuthorizeFolder("/Audios");
                option.Conventions.AuthorizeFolder("/Categorys");
                option.Conventions.AuthorizeFolder("/Companys");
                option.Conventions.AuthorizeFolder("/MadeRole");
                option.Conventions.AuthorizeFolder("/MoveText");
                option.Conventions.AuthorizeFolder("/News");
                option.Conventions.AuthorizeFolder("/NewsTags");
                option.Conventions.AuthorizeFolder("/Papers");
                option.Conventions.AuthorizeFolder("/Photos");
                option.Conventions.AuthorizeFolder("/PhotoTag");
                option.Conventions.AuthorizeFolder("/RoleUser");
                option.Conventions.AuthorizeFolder("/SocialManagment");
                option.Conventions.AuthorizeFolder("/Statements");
                option.Conventions.AuthorizeFolder("/Studies");
                option.Conventions.AuthorizeFolder("/Tags");
                option.Conventions.AuthorizeFolder("/Videos");
                option.Conventions.AuthorizeFolder("/VideosTags");
                option.Conventions.AuthorizePage("/Index");
                option.Conventions.AuthorizePage("/SelectTag");
                option.Conventions.AuthorizePage("/UsersManagment");
            });
            //services.AddAuthorization(option =>
            //{
            //    option.AddPolicy("MyClaimPolicy", policy => policy.RequireClaim("Permission", "MyClaim"));

            //});
            services.AddTransient<ISecurityTrimmingService, SecurityTrimmingService>();
            services.AddNicePermissionService();



            services.AddScoped<INewsPagination, NewsPagination>();
            services.AddScoped<IVideoPagination, VideoPagination>();
            services.AddScoped<IPhotoPagination, PhotoPagination>();
            services.AddScoped<IPaperPagination, PaperPagination>();
            services.AddScoped<ITagsPagination, TagsPagination>();
            services.AddScoped<IStudiesPagination, StudiesPagination>();
            services.AddScoped<IStatementPagination, StatementPagination>();
            services.AddScoped<IAudiosPagination, AudiosPagination>();


            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();

            services.AddScoped<SignInManager<AppUser>>();
            services.AddScoped<UserManager<AppUser>>();

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
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
                DefaultRequestCulture = new RequestCulture("ar-SA"),
                SupportedCultures = myCultures,
                SupportedUICultures = myCultures,
                RequestCultureProviders = new List<IRequestCultureProvider>()
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
                endpoints.MapRazorPages();
            });
        }
    }
}
