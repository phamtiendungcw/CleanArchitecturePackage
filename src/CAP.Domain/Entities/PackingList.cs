using CAP.Domain.Exceptions;
using CAP.Domain.ValueObjects;

namespace CAP.Domain.Entities
{
    public class PackingList
    {
        public Guid Id { get; private set; }

        private PackingListName _name;
        private Localization _localization;

        private readonly LinkedList<PackingItem> _items = new();

        internal PackingList(Guid id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
        {
            Id = id;
            _name = name;
            _localization = localization;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExists = _items.Any(x => x.Name == item.Name);

            if (alreadyExists)
            {
                throw new PackingItemAlreadyExistsException(_name, item.Name);
            }

            _items.AddLast(item);
        }
    }
}