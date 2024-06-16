using ConsoleApp1.Services;
using ConsoleApp1.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<App>();
            serviceCollection.AddSingleton<IUserInfoService, UserInfoService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var app = serviceProvider.GetService<App>();
            app.Main(); 
        }
    }
}
