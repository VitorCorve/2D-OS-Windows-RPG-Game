using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment.Interfaces
{
    public interface IDurablityManager
    {
        WearedEquipment DecreaseDurabilityAfterFight(WearedEquipment equipment);
        WearedEquipment RecoverWearedEquipment(WearedEquipment equipment);
        int CalculateRepairValue(WearedEquipment equipment);
    }
}
