namespace UtmBuilder.Core.ValueObjects
{
    /// <summary>
    /// Generate a new campaign
    /// </summary>
    /// <param name="id">The ads campaign id.</param>
    /// <param name="source">The referrer (e.g. google, newsletter)</param>
    /// <param name="medium">Marketing medium (e.g. cpc, banner, email)</param>
    /// <param name="name">Product, promo code, or slogan (e.g. spring_sale) One of campaign name or campaign id are required.</param>
    /// <param name="term">Identify the paid keywords</param>
    /// <param name="content">Use to differentiate ads</param>
    public class Campaign(
        string source, 
        string medium, 
        string name, 
        string? id = null, 
        string? term = null, 
        string? content = null) : ValueObject
    {
        /// <summary>
        /// The ads campaign id.
        /// </summary>
        public string? Id { get; } = id;
        /// <summary>
        /// The referrer (e.g. google, newsletter)
        /// </summary>
        public string Source { get; } = source;
        /// <summary>
        /// Marketing medium (e.g. cpc, banner, email)
        /// </summary>
        public string Medium { get; } = medium;
        /// <summary>
        /// Product, promo code, or slogan (e.g. spring_sale) One of campaign name or campaign id are required.
        /// </summary>
        public string Name { get; } = name;
        /// <summary>
        /// Identify the paid keywords
        /// </summary>
        public string? Term { get; } = term;
        /// <summary>
        /// Use to differentiate ads
        /// </summary>
        public string? Content { get; } = content;
    }
}
