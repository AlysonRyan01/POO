using POO.Core.ValueObjects;

namespace POO.Core
{
    public class Utm
    {
        public Utm(Url url, Campaign campaign)
        {
            Campaign = campaign;
            Url = url;
        }

        public Url Url { get; private set; }
        public Campaign Campaign { get; private set; }
    }
}