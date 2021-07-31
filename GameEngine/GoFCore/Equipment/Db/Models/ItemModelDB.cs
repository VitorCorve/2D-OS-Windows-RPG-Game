using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment.Db.Models
{
    public class ItemModelDB
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string Quality { get; set; }
        public string WearType { get; set; }
        public int Price { get; set; }
    }
}
