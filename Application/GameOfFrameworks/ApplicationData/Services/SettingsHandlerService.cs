using GameOfFrameworks.ApplicationData.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;

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
                applicationSettings.Bindings.Bindings = SetDefaultButtonsBindings();
                return applicationSettings;
            }
        }
        private List<IButtonBinding> SetDefaultButtonsBindings()
        {
            var bindingsList = new List<IButtonBinding>();

            for (int i = 0; i < 12; i++)
            {
                bindingsList.Add(new ButtonBinding());
            }

            bindingsList[0] = new ButtonBinding(Key.Q, 0);
            bindingsList[1] = new ButtonBinding(Key.W, 1);
            bindingsList[2] = new ButtonBinding(Key.E, 2);
            bindingsList[3] = new ButtonBinding(Key.R, 3);
            bindingsList[4] = new ButtonBinding(Key.T, 4);
            bindingsList[5] = new ButtonBinding(Key.A, 5);
            bindingsList[6] = new ButtonBinding(Key.S, 6);
            bindingsList[7] = new ButtonBinding(Key.D, 7);
            bindingsList[8] = new ButtonBinding(Key.F, 8);
            bindingsList[9] = new ButtonBinding(Key.X, 9);
            bindingsList[10] = new ButtonBinding(Key.F1, 10);
            bindingsList[11] = new ButtonBinding(Key.F2, 11);

            return bindingsList;
        }
    }
}
