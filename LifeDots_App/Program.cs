using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LifeDots_App.Services;
using LifeDots_App.Interfaces;

namespace LifeDots_App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<ICounterHandler, CounterHandler>();
            builder.Services.AddScoped<IDotGenerator, DotGenerator>();
            builder.Services.AddScoped<IDotColorizer, DotColorizer>();
            builder.Services.AddScoped<IMessageService, MessageService>();
            builder.Services.AddScoped<IHomeService, HomeService>();

            await builder.Build().RunAsync();
        }
    }
}
