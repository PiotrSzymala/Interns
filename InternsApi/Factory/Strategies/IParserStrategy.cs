using InternsApi.Models;

namespace InternsApi.Factory.Strategies
{
    public interface IParserStrategy
    {
        List<Intern> Parse(string data);
    }
}
