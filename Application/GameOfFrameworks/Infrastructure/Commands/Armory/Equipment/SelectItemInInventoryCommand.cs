﻿using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.Services;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class SelectItemInInventoryCommand : ICommand
    {
        public EquipmentControlViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public SelectItemInInventoryCommand(EquipmentControlViewModel equipmentControlViewModel) => ViewModel = equipmentControlViewModel;
        public bool CanExecute(object parameter)
        {
            if (parameter is null)
                return false;
            return true;
        }
        public void Execute(object parameter)
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();
            var selectedItem = (EquipmentUserInterfaceViewTemplate)parameter;
            ViewModel.SelectedItem = selectedItem;
            ViewModel.ItemDescription = itemDescriptionBuilder.Build(ViewModel.SelectedItem?.Source);
            ViewModel.DescriptionToolTipVisibility = System.Windows.Visibility.Visible;
        }
    }
}