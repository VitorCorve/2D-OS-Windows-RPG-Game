﻿using GameOfFrameworks.Models.Temporary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfFrameworks.Scenes
{
    /// <summary>
    /// Логика взаимодействия для BattleWindow.xaml
    /// </summary>
    public partial class BattleWindow : Page
    {
        public BattleWindow()
        {
            InitializeComponent();
            BattleWindowTemporaryData.Instance = this;
        }
    }
}
