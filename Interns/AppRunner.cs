using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.CommandLine.Parsing;
using Interns.Controllers;
using Interns.Handlers;

namespace Interns;

internal static class AppRunner
{
    public static int Run(string[] args)
    {
        var max = Commands.MaxAge();
        var count = Commands.Count();


        max.Handler = CommandHandler.Create<string, IConsole>(MaxAgeCommandHandler.HandleMaxAge);
        count.Handler = CommandHandler.Create<string, int?, int?, IConsole>(CountCommandHandler.HandleCount);

        var cmd = new RootCommand()
        {
            max,
            count
        };

        var parser = CustomParser.GetParser(cmd);

        return parser.Invoke(args);
    }
}