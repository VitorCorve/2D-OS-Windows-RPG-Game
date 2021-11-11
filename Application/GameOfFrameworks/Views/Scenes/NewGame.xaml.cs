using GameOfFrameworks.Models.Temporary;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GameOfFrameworks.Scenes
{
    /// <summary>
    /// Логика взаимодействия для NewGame.xaml
    /// </summary>
    public partial class NewGame : Page
    {
        public NewGame()
        {
            InitializeComponent();
            ConfirmCharacterCreationDialog.NoButton.Click += EnableDialogBehindUI;
            ConfirmCharacterCreationDialog.NoButton.Click += HideConfirmCharacterCreationDialog;
            ConfirmCharacterCreationDialog.YesButton.Click += DisableDialogBehindUI;
            ConfirmCharacterCreationDialog.YesButton.Click += ConfirmCharacterCreation;
            WarningDialog.OkButton.Click += EnableDialogBehindUI;
            WarningDialog.OkButton.Click += HideWarningDialog;
            NameTextBox.Focus();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            RunGame runGame = new RunGame();
            NavigationService.Navigate(runGame);
        }
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            if (NameTextBox.Text.Length < 3 )
            {
                WarningDialog.WarningText.Text = "Character name must contains 3 or more symbols";
                WarningDialog.Visibility = Visibility.Visible;
                DisableDialogBehindUI(sender, e);
                return;
            }
            ConfirmCharacterCreationDialog.Visibility = Visibility.Visible;
            DisableDialogBehindUI(sender, e);
        }
        private void DisableDialogBehindUI(object sender, RoutedEventArgs e)
        {
            NameTextBox.IsEnabled = false;
            MaleButton.IsEnabled = false;
            FemaleButton.IsEnabled = false;
            WarriorButton.IsEnabled = false;
            RogueButton.IsEnabled = false;
            MageButton.IsEnabled = false;
            PreviousAvatarButton.IsEnabled = false;
            NextAvatarButton.IsEnabled = false;
            BackButton.IsEnabled = false;
            BioTextBox.IsEnabled = false;
            ConfirmButton.IsEnabled = false;
            StrengthDescriptionButton.IsEnabled = false;
            StaminaDescriptionButton.IsEnabled = false;
            EnduranceDescriptionButton.IsEnabled = false;
            IntellectDescriptionButton.IsEnabled = false;
            AgilityDescriptionButton.IsEnabled = false;
        }
        private void EnableDialogBehindUI(object sender, RoutedEventArgs e)
        {
            NameTextBox.IsEnabled = true;
            MaleButton.IsEnabled = true;
            FemaleButton.IsEnabled = true;
            WarriorButton.IsEnabled = true;
            RogueButton.IsEnabled = true;
            MageButton.IsEnabled = true;
            PreviousAvatarButton.IsEnabled = true;
            NextAvatarButton.IsEnabled = true;
            BackButton.IsEnabled = true;
            BioTextBox.IsEnabled = true;
            ConfirmButton.IsEnabled = true;
            StrengthDescriptionButton.IsEnabled = true;
            StaminaDescriptionButton.IsEnabled = true;
            EnduranceDescriptionButton.IsEnabled = true;
            IntellectDescriptionButton.IsEnabled = true;
            AgilityDescriptionButton.IsEnabled = true;
        }
        private void HideConfirmCharacterCreationDialog(object sender, RoutedEventArgs e) => ConfirmCharacterCreationDialog.Visibility = Visibility.Hidden;
        private void HideWarningDialog(object sender, RoutedEventArgs e) => WarningDialog.Visibility = Visibility.Hidden;
        private void ConfirmCharacterCreation(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            ApplyCharacterCreation apply = new ApplyCharacterCreation();
            NavigationService.Navigate(apply);
        }
        private void WarriorButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void RogueButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void MageButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void MaleButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void FemaleButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void PreviousAvatarButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void NextAvatarButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void StrengthDescriptionButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void StaminaDescriptionButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void EnduranceDescriptionButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void IntellectDescriptionButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void AgilityDescriptionButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void BackButton_Click_1(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
