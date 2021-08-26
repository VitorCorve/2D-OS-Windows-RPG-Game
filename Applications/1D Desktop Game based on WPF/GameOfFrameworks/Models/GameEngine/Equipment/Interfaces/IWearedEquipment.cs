using GameEngine.Equipment.Resource;
using System.Collections.Generic;

namespace GameEngine.Equipment.Interfaces
{
    public interface IWearedEquipment
    {
        List<ItemEntity> ItemsList { get; }
        void WearGear(ItemEntity item);
        void TakeOffGear(ItemEntity item);
    }
}
