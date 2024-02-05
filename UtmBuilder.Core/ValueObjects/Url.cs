using System.Text.RegularExpressions;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (Website link)</param>
    public partial class Url : ValueObject
    {
        private const string UrlRegex = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";

        public Url(string address)
        {
            Address = address;
            if (!Urlregex().IsMatch(address))            
                throw new InvalidUrlException();
            
        }

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; }

        [GeneratedRegex(UrlRegex)]
        private static partial Regex Urlregex();
    }
}
