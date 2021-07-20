using GameEngine.Abstract;
using GameEngine.Player;

namespace GameEngine.Specializatons
{
    public class Warrior : AbstractPlayer
    {

        public Warrior()
        {
            Specialization = SPECIALIZATION.Warrior;
        }
    }
}
