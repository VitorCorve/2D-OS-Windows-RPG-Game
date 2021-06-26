using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface ISkills
    {
        void Strike(NPC npc);
        void Blow(NPC npc);

        void Heal(NPC npc);
        void Heal(Player player);

        void DefenceStance(NPC npc);

        void Rage(NPC npc);

        void Stun(NPC npc);

        void BattleStance(NPC npc);

    }


}
