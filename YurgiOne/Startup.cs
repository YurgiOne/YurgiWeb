using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using YurgiOne.Services;

namespace YurgiOne
{

    public class Startup
    {
       
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INullMailService, NullMailService>();
            //TODO: support for e-mail service

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/error");
            app.UseHsts();

            app.UseStaticFiles();
            app.UseNodeModules();

            app.UseRouting();

            //ways to have multiple subsystems to know about eachother a little bit well
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Fallback", "{controller}/{action}/{id?}",
                    new
                    {
                        controller = "App", action = "Index"
                    });
            });
        }
    }
}