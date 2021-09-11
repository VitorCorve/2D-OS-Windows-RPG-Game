using GameEngine.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface IEquipmentItemView
    {
        ItemEntity Item { get; }
        string ImagePath { get; }
        EQUIPMENT_TYPE EquipmentType { get; }
    }
}
