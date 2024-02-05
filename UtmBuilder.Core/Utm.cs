using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
    public class Utm(Url url, Campaign campaign)
    {
        public Url Url { get; set; } = url;
        public Campaign Campaign { get; set; } = campaign;
    }
}
