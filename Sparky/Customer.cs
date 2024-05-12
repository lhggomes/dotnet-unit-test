using System.Data;

namespace Sparky;

public class Customer
{
    public string CombineNames(string name, string lastName)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Error");
        }
        return $"{name} {lastName}";
    }
}