using GameEngine.CombatEngine;
using GameEngine.Data.Services;
using GameEngine.Player;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Models.LoadGame
{
    public class CharacterSelectionUpdateService
    {
        public LoadGameViewModel ViewModel { get; set; }
        public CharacterSelectionUpdateService(LoadGameViewModel loadGameViewModel) => ViewModel = loadGameViewModel;
        public void Execute()
        {
            if (ViewModel.Names.Count > 0)
            {
                var playerEntityConstructor = new PlayerEntityConstructor();
                var saveDataJsonDeserializer = new SaveDataJsonDeserializer();

                ViewModel.SaveData = saveDataJsonDeserializer.Deserialize(ViewModel.Names[ViewModel.SaveSelectionIndex]);
                ViewModel.SaveDateTime = ViewModel.SaveData.Date;

                ViewModel.PlayerConsumables.ConvertValues(ViewModel.SaveData.Money);

                var playerModelData = new PlayerModelData(ViewModel.SaveData.Specialization, ViewModel.SaveData.Gender, ViewModel.SaveData.Name, ViewModel.SaveData.Level, ViewModel.SaveData.Money);
                ViewModel.CharacterEntity = playerEntityConstructor.CreatePlayer(playerModelData, ViewModel.SaveData.PlayerAttributes);
            }
            else
            {
                ViewModel.OnPropertyChanged(nameof(ViewModel.SaveData));
            }
        }
        public void ExecuteNext()
        {
            if (ViewModel.Names.Count > 0)
            {
                var playerEntityConstructor = new PlayerEntityConstructor();
                var saveDataJsonDeserializer = new SaveDataJsonDeserializer();

                ViewModel.SaveData = saveDataJsonDeserializer.Deserialize(ViewModel.Names[ViewModel.Names.Count-1]);
                ViewModel.SaveDateTime = ViewModel.SaveData.Date;

                ViewModel.PlayerConsumables.ConvertValues(ViewModel.SaveData.Money);

                var playerModelData = new PlayerModelData(ViewModel.SaveData.Specialization, ViewModel.SaveData.Gender, ViewModel.SaveData.Name, ViewModel.SaveData.Level, ViewModel.SaveData.Money);
                ViewModel.CharacterEntity = playerEntityConstructor.CreatePlayer(playerModelData, ViewModel.SaveData.PlayerAttributes);
            }
            else
            {
                ViewModel.OnPropertyChanged(nameof(ViewModel.SaveData));
            }
        }
    }
}
