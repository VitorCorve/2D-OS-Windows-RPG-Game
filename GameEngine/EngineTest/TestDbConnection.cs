using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Equipment.Db.Services;

namespace EngineTest
{
    public class TestDbConnection
    {
        public TestDbConnection()
        {
            var dbConnection = new DbConnectionService();
            Console.WriteLine(dbConnection.Model.ItemName);
        }
    }
}
