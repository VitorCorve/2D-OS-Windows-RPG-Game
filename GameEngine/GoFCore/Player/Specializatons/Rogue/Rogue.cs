using GameEngine.Abstract;
using GameEngine.Player;

namespace GameEngine.Specializatons
{
    public class Rogue : AbstractPlayer
    {
        public Rogue()
        {
            Specialization = SPECIALIZATION.Rogue;
        }
    }
}
