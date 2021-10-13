using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Models.Services
{
    public class ConsoleCommandsList
    {
        public ObservableCollection<string> Commands { get; set; } = new();
        public void AddNewCommandToViewList(List<string> command)
        {
            if (Commands.Count < 30)
            {
                foreach (var item in command)
                {
                    Commands.Add(item);
                }
            }
            else
            {
                foreach (var item in command)
                {
                    Commands.RemoveAt(0);
                    Commands.Add(item);
                }

            }
        }
    }
}
