using GameEngine.Data.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.IO;

namespace GameEngine.Data.Services
{
    public class SaveGameService : ISaveGameService
    {
        public void Save(PlayerSaveData playerData)
        {
            string saveGamePath = playerData.Name;

            var jsonData = JsonConvert.SerializeObject(playerData, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            string workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Directory.CreateDirectory($"{workingDirectory}\\Games\\Game of Frameworks\\Saves\\{saveGamePath}");

            File.WriteAllText($"{workingDirectory}\\Games\\Game of Frameworks\\Saves\\{saveGamePath}\\save.json", jsonData);
        }
        public void Save(PlayerLoadData playerData)
        {
            var dataConverter = new ConvertLoadToSaveFormatService();
            Save(dataConverter.Covert(playerData));
        }
    }
}
