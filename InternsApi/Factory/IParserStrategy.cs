using InternsApi.Models;

namespace InternsApi.Factory
{
    public interface IParserStrategy
    {
        List<Intern> Parse(string data);
    }
}
