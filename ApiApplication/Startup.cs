using ApiApplication.Database;
using ApiApplication.Database.Repositories;
using ApiApplication.Database.Repositories.Abstractions;
using ApiApplication.Mappings;
using ApiApplication.Services;
using ApiApplication.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ApiApplication;

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
        services.AddAutoMapper(typeof(MoviesProfile));

        services
            .AddTransient<IShowtimesRepository, ShowtimesRepository>()
            .AddTransient<ITicketsRepository, TicketsRepository>()
            .AddTransient<IAuditoriumsRepository, AuditoriumsRepository>()
            .AddScoped<IShowtimesService, ShowtimesService>()
            .AddDbContext<CinemaContext>(options =>
                options
                    .UseInMemoryDatabase("CinemaDb")
                    .EnableSensitiveDataLogging()
                    .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning)))
            .AddHttpClient()
            .AddSwaggerGen()
            .AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app
            .UseHttpsRedirection()
            .UseRouting()
            .UseSwagger()
            .UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Movies API"))
            .UseAuthentication()
            .UseAuthorization()
            .UseEndpoints(endpoints => endpoints.MapControllers());

        SampleData.Initialize(app);
    }
}
