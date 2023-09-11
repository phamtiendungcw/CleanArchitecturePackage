using CAP.Shared.Abstractions.Exceptions;

namespace CAP.Domain.Exceptions
{
    public class EmptyPackingListNameException : PackItException
    {
        public EmptyPackingListNameException() : base("packing list name is empty.")
        {
        }
    }
}
