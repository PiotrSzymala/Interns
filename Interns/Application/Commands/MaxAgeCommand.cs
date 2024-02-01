using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interns.Application.Commands
{
    public class MaxAgeCommand : ICommandHandler
    {
        public Command CreateCommand()
        {
            return new Command("max-age", "Find the oldest trainee")
            {
                new Argument<string>("url", "link")
            };
        }
    }
}
