

using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidUrlException(string message) : Exception(message)
    {
        private const string DefaultErrorMessage = "Invalid URL";

        [GeneratedRegex(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$")]
        private static partial Regex UrlRegex();

        public static void ThrowIfInvalidUrl(string url, string message = DefaultErrorMessage)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new InvalidUrlException(message);

            if (!UrlRegex().IsMatch(url))
                throw new InvalidUrlException(message);
        }
        
    }

    
}
