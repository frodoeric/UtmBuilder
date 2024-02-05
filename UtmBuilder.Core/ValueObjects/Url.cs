namespace UtmBuilder.Core.ValueObjects
{
    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (Website link)</param>
    public class Url(string address) : ValueObject
    {
        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; } = address;
    }
}
