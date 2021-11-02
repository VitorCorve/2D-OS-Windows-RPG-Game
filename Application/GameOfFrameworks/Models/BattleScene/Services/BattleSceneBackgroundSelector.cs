using System;

namespace GameOfFrameworks.Models.BattleScene.Services
{
    public class BattleSceneBackgroundSelector
    {
        public static string GetPath() => Environment.CurrentDirectory + "\\Data\\Images\\BattleScenes\\scene" + new Random().Next(1, 19) + ".jpg";
    }
}
