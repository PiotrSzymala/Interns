using Interns.Application.Controllers.Deserialization;
using Interns.Application.Models;
using Newtonsoft.Json;

namespace Interns.Application.Controllers.Deserialization.Json;

internal class JsonParserStrategy : IParserStrategy
{
    public List<Intern> Parse(string input)
    {
        try
        {
            InternsResponse interns = JsonConvert.DeserializeObject<InternsResponse>(input);

            if (interns is null)
                throw new Exception("Wrong");


            return interns;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}