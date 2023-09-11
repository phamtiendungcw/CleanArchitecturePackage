using CAP.Shared.Abstractions.Exceptions;

namespace CAP.Domain.Exceptions
{
    public class EmptyPackingListItemNameException : PackItException
    {
        public EmptyPackingListItemNameException() : base("Packing item name cannot be empty.")
        {
        }
    }
}
