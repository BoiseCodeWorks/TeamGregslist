using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using gregslist.Models;
using gregslist.Repositories;
using gregslist.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace gregslist
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
            services.AddScoped<IDbConnection>(x => CreateDbConnection());
            services.AddTransient<TeamService>();
            services.AddTransient<TeamRepository>();




            // services.AddTransient<IBaseApiService<Team, int>, BaseApiService<Team, int>>();
            // services.AddTransient<BaseApiService<Player, int>>();

            // services.AddTransient<BaseApiRepository<Team, int>>(x => { return new BaseApiRepository<Team, int>(CreateDbConnection(), "teams"); });
            // services.AddTransient<BaseApiRepository<Player, int>>(x => { return new BaseApiRepository<Player, int>(CreateDbConnection(), "players"); });

        }

        private IDbConnection CreateDbConnection()
        {
            string connectionString = Configuration.GetSection("db").GetValue<string>("gearhost");
            return new MySqlConnection(connectionString);
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
        }
    }
}
