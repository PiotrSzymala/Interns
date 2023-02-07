using System.CommandLine;

namespace Interns;

internal static class Commands
{
    public static Command MaxAge()
    {
        return new Command("max-age", "Find the oldest trainee")
        {
            new Argument<string>("url", "link")
        };
    }

    public static Command Count()
    {
        return new Command("count", "Count all trainees")
        {
            new Argument<string>("url" , "link"),
            new Option<int?>("--age-gt", "Find trainees older than certain age"),
            new Option<int?>("--age-lt", "Find trainees younger than certain age"),
        };
    }
}