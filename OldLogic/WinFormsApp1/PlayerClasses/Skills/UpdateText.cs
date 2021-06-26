using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class UpdateText
    {
        public static void Update()
        {
            BattleWindow form = (BattleWindow)Data.BattleWindowForm;
            MessageBox.Show("Success");
        }

    }
}
