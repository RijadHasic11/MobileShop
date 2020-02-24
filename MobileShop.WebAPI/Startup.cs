using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MobileShop.WebAPI.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MobileShop.Model;
using MobileShop.Model.Requests;
using MobileShop.WebAPI.Security;
using MobileShop.WebAPI.Services;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Swagger;


namespace MobileShop.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }

    }

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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<MyContext>(x => x.UseSqlServer(Configuration.GetConnectionString("localDB")));

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();

            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IService<Model.Models.Klijenti,object>,BaseService<Model.Models.Klijenti,object,Model.Database.Klijenti>>();
            services.AddScoped<IService<Model.Models.Zahtjevi, object>, BaseService<Model.Models.Zahtjevi, object, Model.Database.Zahtjevi>>();

            services.AddScoped<ICRUDService<Model.Models.Zahtjevi, ZahtjeviSearchRequest, object, object>, ZahtjeviService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ISkladistaService, SkladistaService>();
            services.AddScoped<IDobavljaciService, DobavljaciService>();
            services.AddScoped<IService<Model.Models.Uloge, object>, BaseService<Model.Models.Uloge, object, Model.Database.Uloge>>();
            services.AddScoped<IStavkeNabavke, StavkeNabavkeService>();
            services.AddScoped<INabavkeService, NabavkeService>();
            services.AddScoped<IService<Model.Models.Dobavljaci, object>, BaseService<Model.Models.Dobavljaci, object, Model.Database.Dobavljaci>>();
            //services.AddScoped<ICRUDService<Model.Models.Dobavljaci, DobavljaciSearchRequest, object, object>, DobavljaciService>();
            services.AddScoped<IArtikliService, ArtikliService>();
            services.AddScoped<IService<Model.Models.Obavijesti, object>, BaseService<Model.Models.Obavijesti, object, Model.Database.Obavijesti>>();
            services.AddScoped<ICRUDService<Model.Models.Obavijesti, Model.Requests.ObavijestiSearchRequest, object, object>, ObavijestiService>();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseAuthentication();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
