using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WinFormsApp1.CharCreation
{
    public static class AttributesDescription
    {
        public static Dictionary<string, string> Description;
        public static string DescriptionChoise { get; set; }

        public static void GetDescription()
        {

            Dictionary<string, string> description = new Dictionary<string, string> { };
            description.Add("strength", File.ReadAllText("Data\\attributes\\Description\\strength.txt"));
            description.Add("stamina", File.ReadAllText("Data\\attributes\\Description\\stamina.txt"));
            description.Add("intellect", File.ReadAllText("Data\\attributes\\Description\\intellect.txt"));
            description.Add("endurance", File.ReadAllText("Data\\attributes\\Description\\endurance.txt"));
            description.Add("agility", File.ReadAllText("Data\\attributes\\Description\\agility.txt"));
            Description = description;
        }
    }
}
