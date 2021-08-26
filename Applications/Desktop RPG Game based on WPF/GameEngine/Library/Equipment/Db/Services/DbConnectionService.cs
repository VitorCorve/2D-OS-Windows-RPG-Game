using GameEngine.Equipment.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment.Db.Services
{
    public class DbConnectionService
    {
        public ItemsDBContext DataBase { get; private set; }
        public DbConnectionService()
        {
            ItemsDBContext db = new ItemsDBContext();
                DataBase = db;
        }
        public ItemModelDB GetModel(int id)
        {
            foreach (var item in DataBase.ItemModels)
            {
                if (id == item.ID)
                    return item;
            }

            throw new Exception("Invalid item ID");
        }

        public ItemAttributes GetAttributes(int id)
        {
            foreach (var item in DataBase.ItemAttributes)
            {
                if (id == item.ID)
                    return item;
            }

            throw new Exception("Invalid item ID");
        }

        public List<ItemModelDB> GetItemsList()
        {
            var items = new List<ItemModelDB> { };
            foreach (var item in DataBase.ItemModels)
                items.Add(item);
            return items;
        }

        public void Close()
        {
            DataBase.Dispose();
        }
    }
}
