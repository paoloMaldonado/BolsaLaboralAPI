using BolsaLaboralWeb.Domain.Core.Interfaces;
using BolsaLaboralWeb.Domain.Infrastructure.Data;
using BolsaLaboralWeb.Domain.Infrastructure.Mappings;
using BolsaLaboralWeb.Domain.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolsaLaboralWeb.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BolsaLaboralWeb.API", Version = "v1" });
            });

            services.AddDbContext<Bolsa_LaboralContext>(x =>
                x.UseSqlServer(Configuration.GetConnectionString("DevConnection")));

            services.AddTransient<IPostulanteRepository, PostulanteRepository>();
            services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
            services.AddTransient<IProvinciaRepository, ProvinciaRepository>();
            services.AddTransient<ICategoriaEmpleoRepository, CategoriaEmpleoRepository>();
            // TODO: Agregar nuevas interfaces


            // Add AutoMapper for DTOs
            services.AddAutoMapper(typeof(AutomapperProfile));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BolsaLaboralWeb.API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
