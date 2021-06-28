using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;

namespace ProtoTinkr
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDYzNzczQDMxMzkyZTMxMmUzMGw4VDBTVDRKRTdyVzFiUW9LNllCVWZoL2x0ckxqMjJISUZHa2g5TFgxZU09;NDYzNzc0QDMxMzkyZTMxMmUzMEhGdVI3dlhyc1V4dkdIL0pjZ2FvZjNBaVFHV0hBUVZEbG4zRGRlNFBFZ1k9;NDYzNzc1QDMxMzkyZTMxMmUzMGFTWWN4N1BnM1lRZkFSdHZFY0xvRXprZWpnaFJaQXIzVUZFL25ZeFRZT009;NDYzNzc2QDMxMzkyZTMxMmUzMEZVYkl3N3hKRXB5L0llTVdhaVVxUDQvbjBhVXRlR2pGczZGcTJwU0tNWEE9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped(
                sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
            await builder.Build().RunAsync();
        }
    }
}
