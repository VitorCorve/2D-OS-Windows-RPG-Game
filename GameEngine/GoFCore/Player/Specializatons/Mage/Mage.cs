using GameEngine.Abstract;
using GameEngine.Player;

namespace GameEngine.Specializatons
{
    public class Mage : AbstractPlayer
    {
        public Mage()
        {
            Specialization = SPECIALIZATION.Mage;
        }
    }
}
