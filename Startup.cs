using Microsoft.EntityFrameworkCore;
using Pawcare.Data;
using System.Text.Json.Serialization;

namespace Pawcare
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void configureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options => 
            options.JsonSerializerOptions.ReferenceHandler= ReferenceHandler.IgnoreCycles);

            //context
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            //cors
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(options =>
                {
                    options.WithOrigins("*").WithMethods("*").WithHeaders("*");
                });
            });
        }

        public void configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(options =>
            {
                options.MapControllers();
            });

        }
    }
}
