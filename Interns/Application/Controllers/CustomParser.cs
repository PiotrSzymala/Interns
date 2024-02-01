using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Help;
using System.CommandLine.Parsing;

namespace Interns.Application.Controllers;

internal static class CustomParser
{
    public static Parser GetParser(RootCommand rootCommand)
    {
        var parser = new CommandLineBuilder(rootCommand)
            .UseParseErrorReporting()
            .UseHelp(ctx =>
            {
                ctx.HelpBuilder.CustomizeLayout(
                    _ =>
                        HelpBuilder.Default
                            .GetLayout()
                            .Skip(15)
                            .Prepend(
                                context => context.Output.WriteLine("Error: Invalid command.")
                            ));
            })
            .Build();
        return parser;
    }
}