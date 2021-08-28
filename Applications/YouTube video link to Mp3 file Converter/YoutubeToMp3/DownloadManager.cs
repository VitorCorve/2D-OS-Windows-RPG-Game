using MediaToolkit;
using MediaToolkit.Model;
using System.IO;
using VideoLibrary;

namespace YoutubeToMp3
{
    public static class DownloadManager
    {
        public static YouTube YoutubeManager { get; } = YouTube.Default;
        public static YouTubeVideo Video { get; private set; }
        public delegate void Action();
        public static event Action OperationFinished;
        public static event Action ShowVideoName;
        public static string DestinationPath { get; set; }
        public static string VideoURL
        {
            get => _VideoURL;
            set => UpdateVideoDescription(value);
        }
        private static string _VideoURL;
        public static string VideoName { get; set; }
        public static void DownloadAndConvert()
        {
            var source = $@"{DestinationPath}\\";

            File.WriteAllBytes(source + VideoName, Video.GetBytes());

            var inputFile = new MediaFile { Filename = source + VideoName };
            var outputFile = new MediaFile { Filename = $"{source + VideoName}.mp3" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }

            File.Delete(source + VideoName);
            OperationFinished();
        }
        public static string Notify() => "Downloaded and converted";
        private static void UpdateVideoDescription(string url)
        {
            _VideoURL = url;

            Video = YoutubeManager.GetVideo($"{VideoURL}");

            VideoName = Video.FullName.Replace(".mp4", "");

            if (VideoName != null && VideoName.Length > 0) ShowVideoName();
        }
    }
}
