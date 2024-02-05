namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public class InvalidUrlException(string message = "Invalid URL") : Exception(message)
    {
    }
}
