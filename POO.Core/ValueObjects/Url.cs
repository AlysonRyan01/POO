using POO.Core.ValueObjects.Exceptions;

namespace POO.Core.ValueObjects
{
    public class Url : BaseValueObject
    {
        public Url(string address) 
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalid(address);
        }

        public string Address { get; private set; }
    }
}