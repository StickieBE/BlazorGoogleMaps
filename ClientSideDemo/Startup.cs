using GoogleMapsComponents.Maps;
using GoogleMapsComponents;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Threading.Tasks;
using MudBlazor.Services;

namespace ClientSideDemo
{
    public class Startup
    {
        private static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            builder.Services.AddMudServices();

            builder.Services.AddBlazorGoogleMaps(new MapApiLoadOptions("AIzaSyBdkgvniMdyFPAcTlcZivr8f30iU-kn1T0"));

            await builder.Build().RunAsync();
        }
    }
}
