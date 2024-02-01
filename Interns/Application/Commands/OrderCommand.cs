using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interns.Application.Commands
{
    public class OrderCommand : ICommandHandler
    {
        public Command CreateCommand()
        {
            return new Command("order", "Order trainees ascending (by default) or descending by age")
            {
                new Argument<string>("url", "link"),
                new Option<bool>("--desc","Order by descending")
            };
        }
    }

}
