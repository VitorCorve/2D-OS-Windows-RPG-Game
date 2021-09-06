using GameEngine.CharacterCreationMaster;
using System;

namespace GameLogicAndFunctionalTests
{
    class TestCharacterCreationModule
    {
        public TestCharacterCreationModule()
        {
            var characterCreationMaster = new CharacterCreationMaster();
            for (int i = 0; i < 10; i++)
            {
                // attributes

                characterCreationMaster.SelectAttributeDescription(0);

                Console.WriteLine("Strength: \t" + characterCreationMaster.CharacterData.CharacterAttributes.Strength);
                Console.WriteLine(characterCreationMaster.CharacterData.AttributeDescription);

                characterCreationMaster.SelectAttributeDescription(1);

                Console.WriteLine("\nStamina: \t" + characterCreationMaster.CharacterData.CharacterAttributes.Stamina);
                Console.WriteLine(characterCreationMaster.CharacterData.AttributeDescription);

                characterCreationMaster.SelectAttributeDescription(2);

                Console.WriteLine("\nEndurance: \t" + characterCreationMaster.CharacterData.CharacterAttributes.Endurance);
                Console.WriteLine(characterCreationMaster.CharacterData.AttributeDescription);

                characterCreationMaster.SelectAttributeDescription(3);

                Console.WriteLine("\nIntellect: \t" + characterCreationMaster.CharacterData.CharacterAttributes.Intellect);
                Console.WriteLine(characterCreationMaster.CharacterData.AttributeDescription);

                characterCreationMaster.SelectAttributeDescription(4);

                Console.WriteLine("\nAgility: \t" + characterCreationMaster.CharacterData.CharacterAttributes.Agility);
                Console.WriteLine(characterCreationMaster.CharacterData.AttributeDescription);

                // gender
                Console.WriteLine("\nGender: \t" + characterCreationMaster.CharacterData.Gender);

                // specialization
                Console.WriteLine("\nSpecialization: \t" + characterCreationMaster.CharacterData.CharacterSpecialization);

                // avatar
                Console.WriteLine("\nAvatar Path: \t" + characterCreationMaster.CharacterData.AvatarPath.Path);

                // personal attribute desctiption
                characterCreationMaster.SelectAttributeDescription(i);

                Console.WriteLine("\n Selected attribute description: \t" + characterCreationMaster.CharacterData.AttributeDescription);
                // available skills

                Console.Write("\n Available skill list: ");
                foreach (var item in characterCreationMaster.CharacterData.AvailableSkills)
                    Console.Write(item.SkillName + ", ");
                characterCreationMaster.SelectGender(1);
                characterCreationMaster.SelectSpecialization(1);

                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            }

        }

    }
}
