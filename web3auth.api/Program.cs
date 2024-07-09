using Microsoft.Extensions.DependencyInjection;
using web3auth.api.Extensions;
using web3auth.api.Services;

var builder = WebApplication.CreateBuilder(args);

var app = builder
            .ConfigureServices()
            .ConfigurePipelines();

app.Run();
