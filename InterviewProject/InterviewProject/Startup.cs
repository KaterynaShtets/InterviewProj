using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using InterviewProject.Data;
using InterviewProject.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InterviewProject
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
            services.AddDbContext<ApplicationContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            //string assemblyName = typeof(ApplicationContext).Namespace;
            //var dbContextBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            //dbContextBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"), o => o.MigrationsAssembly(assemblyName));

            //return new KuchidDbContext(dbContextBuilder.Options);
            // services.AddDbContext<ApplicationContext>(options =>
            //     options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
            //         optionsBuilder =>
            //             optionsBuilder.MigrationsAssembly(assemblyName)
            //     )
            //);
            services.AddControllers();
            services.AddScoped<InterviewRepository>();
            services.AddScoped<IInterviewService, InterviewService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //подключить маршрутизацию контроллеров на основе атрибутов
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
