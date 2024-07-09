using web3auth.api.Endpoints;
using web3auth.api.Services;

namespace web3auth.api.Extensions;

public static class HostingExtension
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {

        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddHttpClient<IWeb3authService, Web3authService>(options =>
        {
            options.BaseAddress = new Uri(builder.Configuration.GetSection("PregeneratedWalletApi").Get<string>()!);
        });

        return builder.Build();
    }

    public static WebApplication ConfigurePipelines(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.MapGroup("web3auth")
            .Web3AuthGroup();

        return app;
    }
}
