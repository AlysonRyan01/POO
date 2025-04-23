namespace POO.Core.ValueObjects.Exceptions
{
    public class InvalidCampaignException : Exception
    {
        private const string DefaultErrorMEssage = "Invalid UTM parameters";

        public InvalidCampaignException(string message = DefaultErrorMEssage) : base(message)
        {
            
        }

        public static void InvalidCampaign(string? item,string message = DefaultErrorMEssage)
        {
            if (string.IsNullOrEmpty(item))
                throw new InvalidCampaignException(message);
        }
    }
}