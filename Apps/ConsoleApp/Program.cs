using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using JLI.Framework.Core;

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

            bool? value = null;
            Console.WriteLine($"bool?\t|\t{value}\t|\t{value.ToJavaScriptLiteral()}");
            value = true;
            Console.WriteLine($"bool?\t|\t{value}\t|\t{value.ToJavaScriptLiteral()}");
            value = false;
            Console.WriteLine($"bool?\t|\t{value}\t|\t{value.ToJavaScriptLiteral()}");

            String stringValue = null;
            Console.WriteLine($"string\t|\t{stringValue}\t|\t{stringValue.ToJavaScriptLiteral()}");
            stringValue = "this is a \"non-null\" string";
            Console.WriteLine($"string\t|\t{stringValue}\t|\t{stringValue.ToJavaScriptLiteral()}");

            Console.WriteLine();
            Console.WriteLine("Press {Enter} to quit.");
            Console.ReadLine();
        }
    }



}
