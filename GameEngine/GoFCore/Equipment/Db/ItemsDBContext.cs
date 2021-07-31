using System.Data.Entity;
using GameEngine.Equipment.Db.Models;

namespace GameEngine.Equipment.Db
{
    public class ItemsDBContext : DbContext
    {
        public ItemsDBContext() :
            base("ItemsDB")
        { }

        public DbSet<ItemModelDB> ItemModels { get; set; } 
        public DbSet<ItemAttributes> ItemAttributes { get; set; }
    }
}
