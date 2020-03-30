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


            
            services.AddScoped<IService<Model.Models.Klijenti,object>,BaseService<Model.Models.Klijenti,object,Model.Database.Klijenti>>();

            services.AddScoped<IService<Model.Models.Zahtjevi, object>, BaseService<Model.Models.Zahtjevi, object, Model.Database.Zahtjevi>>();
            services.AddScoped<ICRUDService<Model.Models.Zahtjevi, ZahtjeviSearchRequest, object, object>, ZahtjeviService>();

            services.AddScoped<IService<Model.Models.Proizvodjaci, object>, BaseService<Model.Models.Proizvodjaci, object, Model.Database.Proizvodjaci>>();
            services.AddScoped<ICRUDService<Model.Models.Proizvodjaci, object, ProizvodjaciInsertRequest, object>, ProizvodjaciService>();

            services.AddScoped<IService<Model.Models.Modeli, object>, BaseService<Model.Models.Modeli, object, Model.Database.Modeli>>();
            services.AddScoped<ICRUDService<Model.Models.Modeli, object, ModeliInsertRequest, object>, ModeliService>();

            services.AddScoped<IService<Model.Models.Karakteristike, object>, BaseService<Model.Models.Karakteristike, object, Model.Database.Karakteristike>>();
            services.AddScoped<ICRUDService<Model.Models.Karakteristike, object, KarakteristikeInsertRequest, object>, KarakteristikeService>();

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IKlijentiService, KlijentiService>();
            services.AddScoped<ISkladistaService, SkladistaService>();
            services.AddScoped<IDobavljaciService, DobavljaciService>();
            services.AddScoped<IService<Model.Models.Uloge, object>, BaseService<Model.Models.Uloge, object, Model.Database.Uloge>>();
            services.AddScoped<IStavkeNabavke, StavkeNabavkeService>();
            services.AddScoped<INabavkeService, NabavkeService>();
            services.AddScoped<IService<Model.Models.Dobavljaci, object>, BaseService<Model.Models.Dobavljaci, object, Model.Database.Dobavljaci>>();
            services.AddScoped<IArtikliService, ArtikliService>();
            services.AddScoped<IService<Model.Models.Obavijesti, object>, BaseService<Model.Models.Obavijesti, object, Model.Database.Obavijesti>>();
            services.AddScoped<ICRUDService<Model.Models.Obavijesti, Model.Requests.ObavijestiSearchRequest,Model.Requests.ObavijestInsertRequest, Model.Requests.ObavijestInsertRequest>, ObavijestiService>();
            services.AddScoped<INarudzbeService, NarudzbeService>();
            services.AddScoped<IStavkeNarudzbeService, StavkeNarudzbeService>();
            services.AddScoped<IService<Model.Models.PoslanaNarudzba,object>,BaseService<Model.Models.PoslanaNarudzba, object, Model.Database.PoslanaNarudzba>>();
            services.AddScoped<ICRUDService<Model.Models.PoslanaNarudzba, object, object, Model.Requests.PoslanaNarudzbaUpdateRequest>, IPoslanaNarudzba>();

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

            //app.UseHttpsRedirection();
            

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseMvc();
            app.UseAuthentication();
        }
    }
}
