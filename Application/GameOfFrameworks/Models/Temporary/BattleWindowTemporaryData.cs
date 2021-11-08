using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameOfFrameworks.Models.Temporary
{
    public static class BattleWindowTemporaryData
    {
        public static Page Instance { get; set; }
        public static BattleWindowViewModel ViewModel { get; set; }
        public static bool IsActive { get; set; }
    }
}
