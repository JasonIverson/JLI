﻿using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using JLI.Framework.Core;
using JLI.Framework.Data;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            Console.WriteLine($"{new string('-', 40)}");
            Console.WriteLine($"Email Validation");
            Console.WriteLine($"{new string('-', 40)}");
            Console.Write($"Type an email address:  ");
            string? email = Console.ReadLine();
            Console.WriteLine($"{email} is a valid email address:  {Validator.IsValidEmailAddress(email)}");
            Console.WriteLine("Press Enter\r\n");
            Console.ReadLine();

            Console.WriteLine($"{new string('-', 40)}");
            Console.WriteLine("ToDigits()");
            Console.WriteLine($"{new string('-', 40)}");
            string tempValue = "jas0n";
            Console.WriteLine($"{tempValue}:  {tempValue.ToDigits()}");

            tempValue = "a1sdfasd2sdfl34sdfsdfsalj5";
            Console.WriteLine($"{tempValue}:  {tempValue.ToDigits()}");

            tempValue = "a1b2c3d4e5f6g7h";
            Console.WriteLine($"{tempValue}:  {tempValue.ToDigits()}");

            tempValue = "1a2b3c4d5e6f7g8h9";
            Console.WriteLine($"{tempValue}:  {tempValue.ToDigits()}");
            Console.WriteLine();

            Settings settings = config.GetRequiredSection("Settings").Get<Settings>();

            Console.WriteLine($"{new string('-', 40)}");
            Console.WriteLine($"{settings.Value}!");
            Console.WriteLine($"{new string('-', 40)}");

            bool? value = null;
            Console.WriteLine($"bool?\t|\t{value}\t|\t{value.ToJavaScriptLiteral()}");
            value = true;
            Console.WriteLine($"bool?\t|\t{value}\t|\t{value.ToJavaScriptLiteral()}");
            value = false;
            Console.WriteLine($"bool?\t|\t{value}\t|\t{value.ToJavaScriptLiteral()}");

            string? stringValue = null;
            Console.WriteLine($"string\t|\t{stringValue}\t|\t{stringValue.ToJavaScriptLiteral()}");
            stringValue = "this is a \"non-null\" string";
            Console.WriteLine($"string\t|\t{stringValue}\t|\t{stringValue.ToJavaScriptLiteral()}");

            Console.WriteLine();
            Console.WriteLine("Press {Enter} to quit.");
            Console.ReadLine();
        }
    }



}
