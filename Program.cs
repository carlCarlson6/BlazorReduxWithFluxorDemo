using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Fluxor;

namespace BlazorReduxDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // Add Fluxor
            builder.Services.AddFluxor(config => {
                config
                    .ScanAssemblies(typeof(Program).Assembly)
                    .UseReduxDevTools();
            });

            await builder.Build().RunAsync();
        }
    }
}
