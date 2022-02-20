using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace InterfaceTeste
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
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
            services.AddTransient<ShoppingCartEBay>();
            services.AddTransient<ShoppingCartFlipCart>();
            services.AddTransient<ShoppingCartAmazon>();
            services.AddTransient<Func<Carts,IShoppingCart>>
            (serviceProvider => key =>
            {
                switch (key)
                {
                    case Carts.Amazon:
                        return serviceProvider.GetService<ShoppingCartAmazon>();
                    case Carts.Flipcart:
                        return serviceProvider.GetService<ShoppingCartEBay>();
                    case Carts.Ebay:
                        return serviceProvider.GetService<ShoppingCartFlipCart>();
                    default:
                        throw new NotImplementedException();
                }
            });

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Interface with Multiple Implementations",
                    Version = "v1",
                    Description = "Same Interface with Multiple Implementation in ASP.NET Core 3.1"
                ,
                    Contact= new OpenApiContact
                    {
                        Name = "Prasad Raveendran",
                        Email = string.Empty,
                        Url = new Uri("https://www.c-sharpcorner.com/members/prasad-nair3")
                    }
                });                
            });
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(sw =>
            {
                sw.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1.0");       

            });
        }
    }
}
