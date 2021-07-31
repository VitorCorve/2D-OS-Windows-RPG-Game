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
        public ItemModelDB Model { get; private set; }
/*        public ItemModel Model { get; private set; }
        public ItemAttributes Attributes { get; private set; }*/
        public DbConnectionService(/*int id*/)
        {
            using(ItemsDBContext db = new ItemsDBContext())
            {
                /*                var models = db.ItemModels;
                                var attributes = db.ItemAttributes;
                                foreach (var item in models)
                                {
                                    if (item.ID == id)
                                        Model = item;
                                }*/
                /*                var itemAttributes = new ItemModelDB
                                { 
                                    ID = 1,
                                    ItemName = "Bad helmet",
                                    Quality = "Poor",
                                    WearType = "Helmet",
                                    Price = 100
                                };

                                db.ItemModels.Add(itemAttributes);
                                db.SaveChanges();*/
                foreach (var item in db.ItemModels)
                {
                    if (item.ID == 1)
                    {
                        Model = item;
                    }
                }
            }
        }
    }
}
