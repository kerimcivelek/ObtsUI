using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ObtsUI.Shared.Abstract;
using ObtsUI.Client.Services;
using Blazored.LocalStorage;
using Blazored.Toast;
using Blazored.Modal;


namespace ObtsUI.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44321/api/") });
         // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.oytspanel.com/api/") });

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredModal();
            builder.Services.AddScoped<IDashBoardService, DashBoardService>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IVehicleBrandService, VehicleBrandService>();
            builder.Services.AddScoped<ICopmanyService, CompanyService>();
            builder.Services.AddScoped<IOperationService, OperationService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IOperationDetailService, OperationDetailService>();
            builder.Services.AddScoped<INoteService, NoteService>();
      
 

            await builder.Build().RunAsync();
        }
    }
}


