using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
    public class Utm(Url url, Campaign campaign)
    {
        /// <summary>
        /// URL (Website link)
        /// </summary>
        public Url Url { get; } = url;
        /// <summary>
        /// Campaing details
        /// </summary>
        public Campaign Campaign { get; } = campaign;
    }
}
