using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (Website link)</param>
    public partial class Url : ValueObject
    {

        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalidUrl(address, "Invalid URL");            
        }

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; }
    }
}
