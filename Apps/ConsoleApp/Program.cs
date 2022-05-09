using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            Settings settings = config.GetRequiredSection("Settings").Get<Settings>();

            Console.WriteLine($"{new String('-', 40)}");
            Console.WriteLine($"{settings.Value}!");
            Console.WriteLine($"{new String('-', 40)}");

            Console.WriteLine();
            Console.WriteLine("Press {Enter} to quit.");
            Console.ReadLine();
        }
    }

    

}
