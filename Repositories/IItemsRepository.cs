using System;
using System.Collections.Generic;
using notes.Entities;

namespace Notes.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}