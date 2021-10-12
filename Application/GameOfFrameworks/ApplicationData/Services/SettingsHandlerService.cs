using Newtonsoft.Json;
using System;
using System.IO;

namespace GameOfFrameworks.ApplicationData.Services
{
    public class SettingsHandlerService
    {
        private readonly string Path = "\\Games\\Game of Frameworks\\Settings\\Configuration.json";
        private readonly string WorkingDirectory;
        public SettingsHandlerService() => WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void Save(ApplicationSettings settings)
        {
            var jsonData = JsonConvert.SerializeObject(settings, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            if (!Directory.Exists($"{WorkingDirectory}\\Games\\Game of Frameworks\\Settings\\"))
                Directory.CreateDirectory($"{WorkingDirectory}\\Games\\Game of Frameworks\\Settings\\");
            File.WriteAllText($"{WorkingDirectory + Path}", jsonData);
        }
        public ApplicationSettings Load()
        {
            try
            {
                var applicationSettings = JsonConvert.DeserializeObject<ApplicationSettings>(File.ReadAllText(WorkingDirectory + Path), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });
                return applicationSettings;
            }
            catch (Exception)
            {
                var applicationSettings = new ApplicationSettings();
                applicationSettings.WindowStyle.SetDefault();
                return applicationSettings;
            }
        }
    }
}
