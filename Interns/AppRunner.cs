using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.CommandLine.Parsing;
using Interns.Application.Controllers;
using Interns.Application.Handlers;

namespace Interns;

internal static class AppRunner
{
    public static async Task<int> Run(string[] args)
    {
        var max = Commands.MaxAge();
        var count = Commands.Count();
        var order = Commands.Order();


        max.Handler = CommandHandler.Create<string, IConsole>(MaxAgeCommandHandler.HandleMaxAge);
        count.Handler = CommandHandler.Create<string, int?, int?, IConsole>(CountCommandHandler.HandleCount);
        order.Handler = CommandHandler.Create<string, bool, IConsole>(OrderCommandHandler.HandleOrder);

        var cmd = new RootCommand()
        {
            max,
            count,
            order
        };

        var parser = CustomParser.GetParser(cmd);

        return parser.Invoke(args);
    }
}