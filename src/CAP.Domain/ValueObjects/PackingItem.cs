using CAP.Domain.Exceptions;

namespace CAP.Domain.ValueObjects
{
    public record PackingItem
    {
        public string Name { get; }
        public uint Quantity { get; }
        public bool IsPacked { get; }

        public PackingItem(string name, uint quantity, bool isPacked)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new EmptyPackingListItemNameException();
            }

            Name = name;
            Quantity = quantity;
            IsPacked = isPacked;
        }
    }
}