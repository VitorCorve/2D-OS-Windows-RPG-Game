using GameEngine.Player;
using GameOfFrameworks.Models.CharacterCreation.Interfaces;
using System;
using System.IO;

namespace GameOfFrameworks.Models.CharacterCreation
{
    public class CharacterSpecializationDescription : ICharacterSpecializationDescription
    {
        public string Description { get; private set; }

        public void SetDescription(SPECIALIZATION playerSpecialization)
        {
            switch (playerSpecialization)
            {
                case SPECIALIZATION.Rogue:
                    Description = File.ReadAllText(Environment.CurrentDirectory + "\\Data\\Specializations\\rogue.txt");
                    return;
                case SPECIALIZATION.Mage:
                    Description = File.ReadAllText(Environment.CurrentDirectory + "\\Data\\Specializations\\mage.txt");
                    return;
                default:
                    Description = File.ReadAllText(Environment.CurrentDirectory + "\\Data\\Specializations\\warrior.txt");
                    return;
            }
        }
    }
}
