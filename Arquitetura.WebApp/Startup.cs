using Arquitetura.InfraEstrutura.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace Arquitetura.WebApp
{
    public class Startup
    {
        private readonly Container container;
        public Startup(IConfiguration configuration)
        {
            container = InjecaoDependenciaConfig.CreateInstance(Lifestyle.Transient);
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            InjecaoDependenciaConfig.IntegrateSimpleInjector(services);
            services.AddMvc();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            InitializeContainer(app);

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
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        private void InitializeContainer(IApplicationBuilder app)
        {
            container.RegisterMvcControllers(app);
            InjecaoDependenciaConfig.Config();
            // Allow Simple Injector to resolve services from ASP.NET Core.
            container.AutoCrossWireAspNetComponents(app);
        }
    }
}
