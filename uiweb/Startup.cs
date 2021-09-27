using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.Abstract;
using business.Concrete;
using data.Abstract;
using data.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace uiweb
{
    public class Startup
    {
        IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<ISocialService, SocialService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<ITagService, TagService>();

            services.AddScoped<ISocialRepo, SocialRepo>();
            services.AddScoped<IAboutRepo, AboutRepo>();
            services.AddScoped<IBlogRepo, BlogRepo>();
            services.AddScoped<IAuthorRepo, AuthorRepo>();
            services.AddScoped<ITagRepo, TagRepo>();



            services.AddDbContext<BlogContext>(options=>options.UseSqlite(_configuration.GetConnectionString("Source")));
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
