using GameEngine.Abstract;

namespace GameEngine.Player.ModelConditions
{
    public class PlayerAvatar : IPlayerAvatar
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public SPECIALIZATION Specialization { get; set; }
    }
}
