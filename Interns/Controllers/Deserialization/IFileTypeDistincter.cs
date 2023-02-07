using Interns.Models;

namespace Interns.Controllers.Deserialization;

internal interface IFileTypeDistincter
{
    RootObject Deserialize(string input);
}