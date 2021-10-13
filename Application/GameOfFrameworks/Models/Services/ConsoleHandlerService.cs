using GameEngine.Console;
using GameOfFrameworks.Models.Temporary;

namespace GameOfFrameworks.Models.Services
{
    public class ConsoleHandlerService
    {
        public static ConsoleEngine SetupConsoleConfiguration()
        {
            return new ConsoleEngine(ArmoryTemporaryData.CharacterEntity,
                ArmoryTemporaryData.PlayerModel,
                ArmoryTemporaryData.PlayerInventory,
                ArmoryTemporaryData.PlayerEquipment,
                ArmoryTemporaryData.PlayerSkills,
                ArmoryTemporaryData.PlayerAttributes);
        }
        public static void UpdateArmory(ConsoleEngine consoleEngine)
        {
            ArmoryTemporaryData.CharacterEntity = consoleEngine.Entity;
            ArmoryTemporaryData.PlayerModel = consoleEngine.Model;
            ArmoryTemporaryData.PlayerInventory = consoleEngine.Inventory;
            ArmoryTemporaryData.PlayerEquipment = consoleEngine.Equipment;
            ArmoryTemporaryData.PlayerSkills = consoleEngine.Skills;
            ArmoryTemporaryData.PlayerAttributes = consoleEngine.Attributes;
        }
    }
}
