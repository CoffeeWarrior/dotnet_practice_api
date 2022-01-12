using firstwebapp.Models;

namespace firstwebapp.Repositories
{
    public class ItemDbRepository : IItemsRepository
    {
        ItemContext context = new();
        public void CreateItem(Item item)
        {
           context.Items.Add(item);
           context.SaveChanges();
        }

        public void DeleteItem(Item item)
        {
            context.Items.Remove(item);
            context.SaveChanges();
        }

        public Item GetItem(Guid id)
        {
            Item item = context.Items.Where(x => x.Id == id).Single();
            return item;
        }

        public IEnumerable<Item> GetItems()
        {
            return context.Items;
        }

        public void UpdateItem(Item item)
        {
            this.DeleteItem(this.GetItem(item.Id));
            this.CreateItem(item);
            context.SaveChanges();
        }
    }
}
