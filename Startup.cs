using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MS_TEST_EJ.Clases_Datos;
using MS_TEST_EJ.Clases_Negocio;
using Swashbuckle.AspNetCore.Swagger;

namespace MS_TEST_EJ
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //Dapper


            //

            //Inyecciones
            services.AddTransient<IDatos, Datos>();
            services.AddTransient<INegocio,Negocio>();
            //

            //Swager
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info { Title = "Employee API", Version = "V1" });
            });
            //

            //log
            //loggerFactory.AddFile("c:/Logs/myapp-{Date}.txt");
            //

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Swager
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "post API V1");
            });
            //

            //Cors


            //

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
