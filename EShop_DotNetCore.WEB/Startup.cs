using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop_DotNetCore.BLL.EntitiesSvc;
using EShop_DotNetCore.COMMON.Constants;
using EShop_DotNetCore.COMMON.IEntitesSvc;
using EShop_DotNetCore.DAL.EF;
using EShop_DotNetCore.DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EShop_DotNetCore.WEB
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
/*
            string connectionString = Configuration.GetConnectionString("DefaultConnection");*/

            services.AddDbContext<EShopDBContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString(SystemConstant.ConnectionStringSU)));

            services.AddControllersWithViews();
            #region -- Swagger --            
            var inf1 = new OpenApiInfo
            {
                Title = "API v1.0",
                Version = "v1",
                Description = "Swashbuckle",
                TermsOfService = new Uri("http://appointvn.com"),
                Contact = new OpenApiContact
                {
                    Name = "Le Thien Bao",
                    Email = "lethienbao3012@gmail.com"
                },
                License = new OpenApiLicense
                {
                    Name = "Apache 2.0",
                    Url = new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
                }
            };

            var inf2 = new OpenApiInfo
            {
                Title = "API v2.0",
                Version = "v2",
                Description = "Swashbuckle",
                TermsOfService = new Uri("http://appointvn.com"),
                Contact = new OpenApiContact
                {
                    Name = "Le Thien Bao",
                    Email = "lethienbao3012@gmail.com"
                },
                License = new OpenApiLicense
                {
                    Name = "Apache 2.0",
                    Url = new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
                }
            };

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", inf1);
                c.SwaggerDoc("v2", inf2);
            });
            #endregion
            //Declare DI
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<EShopDBContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
            services.AddTransient<IUsersSvc, UsersSvc>();
            services.AddSingleton<IConfiguration>(Configuration);


            string issuer = Configuration.GetValue<string>("Tokens:Issuer");
            string signingKey = Configuration.GetValue<string>("Tokens:Key");
       /*     byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);*/

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
            #region -- Swagger --
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1.0");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "API v2.0");
            });
            #endregion


            app.UseCors(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

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
