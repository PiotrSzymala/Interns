using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interns.Application.Commands
{
    internal class CountCommand : ICommandHandler
    {
        public Command CreateCommand()
        {
            return new Command("count", "Count all trainees")
            {
                new Argument<string>("url" , "link"),
                new Option<int?>("--age-gt", "Find trainees older than certain age"),
                new Option<int?>("--age-lt", "Find trainees younger than certain age"),
            };
        }
    }
}
