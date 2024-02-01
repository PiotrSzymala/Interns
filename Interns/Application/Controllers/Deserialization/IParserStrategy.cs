using Interns.Application.Models;

namespace Interns.Application.Controllers.Deserialization;

public interface IParserStrategy
{
    List<Intern> Parse(string input);
}