using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;

namespace GameOfFrameworks.Models.LoadGame
{
    public class SetTemporaryCharacterDataCommand : Command
    {
        public LoadGameModel Model { get; set; }
        public SetTemporaryCharacterDataCommand(LoadGameModel loadGameModel) => Model = loadGameModel;
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            ArmoryTemporaryData.CharacterEntity = Model.CharacterEntity;
            ArmoryTemporaryData.PlayerModel = new PlayerModelData(Model.SaveData);
            ArmoryTemporaryData.SaveData = Model.SaveData;
        }
    }
}
