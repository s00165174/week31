using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using week31.Models;

namespace week31.DAL
{
    public class ShopItemRepository : IShopItemRepository, IDisposable
    {
        CodeMigrationsContext context;
        public ShopItemRepository(CodeMigrationsContext context)
        {
            this.context = context;
        }
        public void DeleteItem(int itemID)
        {
            ShopItem shopItem = context.ShopItems.Find(itemID);
            if (shopItem != null)
            {
                context.ShopItems.Remove(shopItem);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ShopItem GetItemByID(int userID)
        {
            return context.ShopItems.Find(userID);
        }

        public IEnumerable<ShopItem> GetItems()
        {
            return context.ShopItems;
        }

        public void InsertItem(ShopItem item)
        {
            context.ShopItems.Add(item);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateItem(ShopItem item)
        {
            ShopItem shopitem = context.ShopItems.Find(item.ID);
            context.ShopItems.Remove(shopitem);
            context.ShopItems.Add(item);
        }
    }
}