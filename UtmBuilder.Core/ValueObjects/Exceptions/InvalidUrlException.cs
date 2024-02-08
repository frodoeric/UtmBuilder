

using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidUrlException(string message) : Exception(message)
    {
        private const string DefaultErrorMessage = "Invalid URL";
        private const string UrlRegex = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
        [GeneratedRegex(UrlRegex)]
        private static partial Regex Urlregex();

        public static void ThrowIfInvalidUrl(string url, string message = DefaultErrorMessage)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new InvalidUrlException(message);

            if (!Urlregex().IsMatch(url))
                throw new InvalidUrlException(message);
        }
        
    }

    
}
