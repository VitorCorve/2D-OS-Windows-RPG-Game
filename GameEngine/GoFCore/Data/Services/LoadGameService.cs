using GameEngine.Data.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.IO;

namespace GameEngine.Data.Services
{
    public class LoadGameService : ILoadGameService
    {
        public PlayerLoadData Load(string characterName)
        {
            string workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string loadGamePath = characterName;

            var playerData = JsonConvert.DeserializeObject<PlayerSaveData>(File.ReadAllText($"{workingDirectory}\\Games\\Game of Frameworks\\Saves\\{loadGamePath}\\save.json"), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            var playerLoadData = new PlayerLoadData(playerData);

            return playerLoadData;
        }
    }
}
