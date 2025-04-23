using POO.Core.ValueObjects.Exceptions;

namespace POO.Core.ValueObjects
{
    public class Campaign : BaseValueObject
    {
        public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;

            InvalidCampaignException.InvalidCampaign(source, "Source is invalid");
            InvalidCampaignException.InvalidCampaign(medium, "Medium is invalid");
            InvalidCampaignException.InvalidCampaign(name, "Name is invalid");
        }
        
        public string? Id { get; private set; }
        public string? Term { get; private set; }
        public string? Content { get; private set; }
        public string Source { get; private set; }
        public string Medium { get; private set; }
        public string Name { get; private set; }
    }
}