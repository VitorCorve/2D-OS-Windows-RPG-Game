using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interface
{
    public static class InitializeSkillImages
    {

        public static List<string>                  warriorSkillsKUP;
        public static List<string>                  warriorSkillsKDOWN;



        public static List<string>                  rogueSkillsKUP;
        public static List<string>                  rogueSkillsKDOWN;



        public static List<string>                  mageSkillsKUP;
        public static List<string>                  mageSkillsKDOWN;


        public static void Initialize()
        {
            InitializeSkillImagesForMage();
            InitializeSkillImagesForRogue();
            InitializeSkillImagesForWarrior();
        }
        public static void InitializeSkillImagesForWarrior()
        {

            List<string> imgKUP = new List<string> { };
            List<string> imgKDOWN = new List<string> { };

            for (int i = 1; i <= 5; i++)
            {


                imgKUP.Add($"images\\skills\\warrior\\relButton\\{i}.jpg");


                imgKDOWN.Add($"images\\skills\\warrior\\pressButton\\{i}.jpg");


                warriorSkillsKUP = imgKUP;
                warriorSkillsKDOWN = imgKDOWN;
            }
        }

        public static void InitializeSkillImagesForMage()
        {
            List<string> imgKUP = new List<string> { };
            List<string> imgKDOWN = new List<string> { };

            for (int i = 1; i <= 5; i++)
            {




                imgKUP.Add($"images\\skills\\mage\\relButton\\{i}.jpg");


                imgKDOWN.Add($"images\\skills\\mage\\pressButton\\{i}.jpg");

                mageSkillsKUP = imgKUP;
                mageSkillsKDOWN = imgKDOWN;
            }
        }

        public static void InitializeSkillImagesForRogue()
        {
            List<string> imgKUP = new List<string> { };
            List<string> imgKDOWN = new List<string> { };

            for (int i = 1; i <= 5; i++)
            {


                imgKUP.Add($"images\\skills\\rogue\\relButton\\{i}.jpg");


                imgKDOWN.Add($"images\\skills\\rogue\\pressButton\\{i}.jpg");

                rogueSkillsKUP = imgKUP;
                rogueSkillsKDOWN = imgKDOWN;
            }
        }
    }
}
