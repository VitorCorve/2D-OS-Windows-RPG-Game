using System;
using System.IO;

namespace YoutubeToMp3.Managers
{
    public static class DestinationManager
    {
        public static string DestinationPath { get; set; }
        public static void CheckActualDestinationPath()
        {
            string destinationPath = $"{Environment.CurrentDirectory}" + "\\Destination.txt";
            if (File.Exists(destinationPath))
                DestinationPath = File.ReadAllText(destinationPath);
            else
                File.WriteAllText($"{Environment.CurrentDirectory}" + "\\Destination.txt", "E:\\Mus");
        }
        public static void UpdateDestinationPath(string path) => File.WriteAllText($"{Environment.CurrentDirectory}" + "\\Destination.txt", path);
    }
}
