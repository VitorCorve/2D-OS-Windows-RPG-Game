using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interface.BattleWindow
{
    public static class Backgrounds
    {
        public static string GetURL()
        {
            List<string> scenesURL = new List<string> { };

            for (int i = 1; i <= 19; i++)
            {
                scenesURL.Add($"images\\battlescenes\\Scene{i}.jpg");
            }

            Random sceneNumber = new Random();

            return scenesURL[sceneNumber.Next(1, 20)];

        }
    }
}
