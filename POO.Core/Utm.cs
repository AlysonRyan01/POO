using POO.Core.Extensions;
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

        public override string ToString()
        {
            var segments = new List<string>();
            segments.AddIfNotNull(new List<string?>{Campaign.Id, Campaign.Term, Campaign.Content, Campaign.Source, Campaign.Medium, Campaign.Name});
            
            return $"{Url.Address}?{string.Join("&", segments)}";
        }
    }
}