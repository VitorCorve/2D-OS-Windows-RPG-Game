using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.CombatTextData
{
    public static class CritHitColorsNPC
    {
        public static int Red { get; set; }
        public static int Green { get; set; }
        public static int Blue { get; set; }

        public static int Stage = 1;

        public static int[] Color { get; set; }

        public static void Initialize()
        {
            if (Stage == 0)
            {
                Stage = 1;
            }
            switch (Stage)
            {
                case 1:
                    Stage1();
                    break;
                case 2:
                    Stage2();
                    break;
                case 3:
                    Stage3();
                    break;
                case 4:
                    Stage4();
                    break;
                case 5:
                    Stage5();
                    break;
                case 6:
                    Stage6();
                    break;
                case 7:
                    Stage7();
                    break;
                case 8:
                    Stage8();
                    break;
                case 9:
                    Stage9();
                    break;
                case 10:
                    Stage10();
                    break;
                default:
                    break;
            }
        }

        private static void Stage1()
        {
            Red = 188;
            Green = 0;
            Blue = 0;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 2;

        }

        private static void Stage2()
        {
            Red = 255;
            Green = 97;
            Blue = 97;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 3;
        }

        private static void Stage3()
        {
            Red = 255;
            Green = 117;
            Blue = 117;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 4;
        }

        private static void Stage4()
        {
            Red = 255;
            Green = 141;
            Blue = 141;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 5;
        }

        private static void Stage5()
        {
            Red = 255;
            Green = 166;
            Blue = 166;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 6;
        }

        private static void Stage6()
        {
            Red = 255;
            Green = 179;
            Blue = 179;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 7;
        }

        private static void Stage7()
        {
            Red = 255;
            Green = 196;
            Blue = 196;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 8;
        }

        private static void Stage8()
        {
            Red = 255;
            Green = 218;
            Blue = 218;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 9;
        }

        private static void Stage9()
        {
            Red = 255;
            Green = 236;
            Blue = 236;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 10;
        }
        private static void Stage10()
        {
            Red = 240;
            Green = 240;
            Blue = 240;

            int[] colors = new int[3];

            colors[0] = Red;
            colors[1] = Green;
            colors[2] = Blue;

            Color = colors;

            Stage = 0;
        }

    }
}
