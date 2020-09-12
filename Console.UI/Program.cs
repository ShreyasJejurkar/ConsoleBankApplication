using System;
using System.Reflection;
using AlexaBank.ConsoleUI.Application.Accounts.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AlexaBank.ConsoleUI
{
    public class Program
    {
        private static IServiceProvider _serviceProvider;

        public static void Main()
        {
            RegisterServices();

            IMediator mediator = _serviceProvider.GetService<IMediator>();

            Console.WriteLine("Welcome to Alexa Bank.");
            Console.WriteLine("Please choose from following options");

            Console.WriteLine("1. Register a new account");
            Console.WriteLine("2. Log in to existing account");

            var userOption = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (userOption)
            {
                case 1:
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}
