using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp1.CharCreation
{
    public static class SpecializationDescription
    {
        public static Dictionary<string, string> Description;

        public static void GetDescription()
        {

            Dictionary<string, string> description = new Dictionary<string, string> { };
            description.Add("warrior", File.ReadAllText("Data\\characters\\Description\\warrior.txt"));
            description.Add("rogue", File.ReadAllText("Data\\characters\\Description\\rogue.txt"));
            description.Add("mage", File.ReadAllText("Data\\characters\\Description\\mage.txt"));
            Description = description;
        }

    }
}
