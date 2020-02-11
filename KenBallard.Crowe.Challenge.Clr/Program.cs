using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

namespace KenBallard.Crowe.Challenge.Clr
{
    class Program
    {
        static  void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();


            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.GetStringAsync(configuration["Api:GreetingUrl"]).Result;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"The Greeting Service responded with the following value:\r\n\r\n{response}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
