using System;
using GameEngine.Specializatons;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Abstract;

namespace GameEngine.Player
{
    public class PlayerMeta
    {
        public readonly string Name;

        public readonly string Specialization;

        public readonly string Gender;

        public readonly uint Level;

        public PlayerMeta(AbstractPlayer player, string gender, string name, uint level)
        {
            Name = name;
            Specialization = player.Specialization;
            Gender = gender;
            Level = level;
        }


    }
}
