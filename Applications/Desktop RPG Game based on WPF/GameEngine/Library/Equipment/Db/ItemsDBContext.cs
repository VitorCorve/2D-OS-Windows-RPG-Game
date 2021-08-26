using System;
using System.Data.Entity;
using GameEngine.Equipment.Db.Models;

namespace GameEngine.Equipment.Db
{
    public class ItemsDBContext : DbContext
    {
        public ItemsDBContext() :
            base($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={AppDomain.CurrentDomain.BaseDirectory}\\Data\\Equipment\\ItemsDB.mdf;Integrated Security=True")
        {}

        public DbSet<ItemModelDB> ItemModels { get; set; } 
        public DbSet<ItemAttributes> ItemAttributes { get; set; }
    }
}
