using GameEngine.Data;

namespace GameOfFrameworks.Models.Armory.Options
{
    public class SaveGamePresentationModel
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public PlayerSaveData SaveData { get; set; }
    }
}
