using Cinema.WebApi.Configuration;
using Cinema.WebApi.Models;
using Cinema.WebApi.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cinema.WebApi
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
            services.AddAuthentication(Constants.CookieAuthScheme)
                .AddCookie(Constants.CookieAuthScheme, config =>
                {
                    config.Cookie.Name = "Cinema.WebApi";
                    
                });

            services.AddDbContext<MovieContext>(opts => opts.UseSqlServer(Configuration["ConnectionString"]));
            services.AddDbContext<RepertoryContext>(opts => opts.UseSqlServer(Configuration["ConnectionString"]));
            services.AddDbContext<HallContext>(opts => opts.UseSqlServer(Configuration["ConnectionString"]));
            services.AddDbContext<UserContext>(opts => opts.UseSqlServer(Configuration["ConnectionString"]));
            services.AddDbContext<TicketContext>(opts => opts.UseSqlServer(Configuration["ConnectionString"]));
            services.AddScoped<IDataRepository<Movie>, MovieManager>();
            services.AddScoped<IDataRepository<Hall>, HallManager>();
            services.AddScoped<IRepertoryRepository<Repertory>, RepertoryManager>();
            services.AddScoped<IUsersRepository<User>, UserManager>();
            services.AddScoped<ITicketRepository<Ticket>, TicketManager>();

            services.AddControllers();
            services.AddCors(o => o.AddPolicy(Constants.CorsPolicy, builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddMvc()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1)
                .AddMvcOptions(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseHttpsRedirection();

            app.UseRouting();       

            app.UseCors(Constants.CorsPolicy);

            app.UseMvc();
        }
    }
}
