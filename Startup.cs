using Microsoft.ASPNetCore.Builder;
using Microsoft.ASPNetCore.Hosting;
using Microsoft.Extension.DependencyInjection;
using Microsoft.Extension.Hosting;

namespace HMS 
{
    public class Startup {


        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {

            if (env.IsDevelopment()) {
                app.useDeveloperExceptionPage();
            }

            else {
                app.UseExceptionHandler("/Home/Error");
                app.UseHosts()
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default", pattern: "{controller=Doctor}/{action=List}/{id?}");
            });
        }
    }

}