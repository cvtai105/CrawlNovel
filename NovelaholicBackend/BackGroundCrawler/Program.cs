using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

using IHost host = builder.Build();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();


await host.RunAsync();