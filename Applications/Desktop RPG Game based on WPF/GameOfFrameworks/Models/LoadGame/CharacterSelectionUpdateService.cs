using GameEngine.CombatEngine;
using GameEngine.Data.Services;
using GameEngine.Player;

namespace GameOfFrameworks.Models.LoadGame
{
    public class CharacterSelectionUpdateService
    {
        public LoadGameModel Model { get; set; }
        public CharacterSelectionUpdateService(LoadGameModel model) => Model = model;
        public void Execute()
        {
            if (Model.GameSaves.Count > 0)
            {
                var playerEntityConstructor = new PlayerEntityConstructor();
                var saveDataJsonDeserializer = new SaveDataJsonDeserializer();

                Model.SaveData = saveDataJsonDeserializer.Deserialize(Model.GameSaves[Model.SaveSelectionIndex].Path);
                Model.SaveDateTime = Model.SaveData.Date;
                Model.CharacterSpecialization = "Specialization: " + Model.SaveData.Specialization.ToString();
                Model.CharacterGender = "Gender: " + Model.SaveData.Gender.ToString();

                Model.PlayerConsumables.ConvertValues(Model.SaveData.Money);

                var playerModelData = new PlayerModelData(Model.SaveData.Specialization, Model.SaveData.Gender, Model.SaveData.Name, Model.SaveData.Level, Model.SaveData.Money);
                Model.CharacterEntity = playerEntityConstructor.CreatePlayer(playerModelData, Model.SaveData.PlayerAttributes);
            }
        }
        public void ExecuteNext()
        {
            if (Model.GameSaves.Count > 0)
            {
                var playerEntityConstructor = new PlayerEntityConstructor();
                var saveDataJsonDeserializer = new SaveDataJsonDeserializer();

                if (Model.SaveSelectionIndex == Model.GameSaves.Count-1)
                    Model.SaveData = saveDataJsonDeserializer.Deserialize(Model.GameSaves[Model.SaveSelectionIndex = 0].Path);
                else
                    Model.SaveData = saveDataJsonDeserializer.Deserialize(Model.GameSaves[Model.SaveSelectionIndex += 1].Path);

                Model.CharacterSpecialization = "Specialization: " + Model.SaveData.Specialization.ToString();
                Model.SaveDateTime = Model.SaveData.Date;
                Model.PlayerConsumables.ConvertValues(Model.SaveData.Money);

                var playerModelData = new PlayerModelData(Model.SaveData.Specialization, Model.SaveData.Gender, Model.SaveData.Name, Model.SaveData.Level, Model.SaveData.Money);
                Model.CharacterEntity = playerEntityConstructor.CreatePlayer(playerModelData, Model.SaveData.PlayerAttributes);
            }
        }
    }
}
