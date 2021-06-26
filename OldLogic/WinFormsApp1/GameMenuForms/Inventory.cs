using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1.GameMenuForms
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();

            Opacity = 0;

            Timer opacity = new Timer();
            opacity.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 5) opacity.Stop();
            });
            opacity.Interval = 5;
            opacity.Start();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            goldLabel.Text = "Gold: " + Convert.ToString(player.gold);
            silverLabel.Text = "Silver: " + Convert.ToString(player.silver);
            copperLabel.Text = "Copper: " + Convert.ToString(player.copper);



        }
    }
}
