using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment.Interfaces
{
    public interface IEquipmentDurability
    {
        int Value { get; }
        void Decrease(int value);
        void Increase(int value);
    }
}
