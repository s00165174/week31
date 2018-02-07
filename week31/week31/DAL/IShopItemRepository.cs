using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using week31.Models;

namespace week31.DAL
{
    public interface IShopItemRepository:IDisposable
    {
        IEnumerable<ShopItem> GetItems();
        ShopItem GetItemByID(int userID);
        void InsertItem(ShopItem item);
        void UpdateItem(ShopItem item);
        void DeleteItem(int itemID);
        void Save();
    }
}