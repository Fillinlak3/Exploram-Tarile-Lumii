using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploram_Tarile_Lumii.Scenes
{
    public partial class SelectGamemode : UserControl
    {
        public SelectGamemode()
        {
            InitializeComponent();
        }

        private void ReturnToMenu(object sender, EventArgs e)
        {
            Main_Form.HideAllViews();
            Main_Form.Scene_MainMenu.Visible = true;
        }

        private void BTN_GuessTheFlags_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new Gamemodes.GuessTheFlag());
            this.Controls[Controls.Count - 1].BringToFront();
            Debug.WriteLine(Controls.Count);
        }
    }
}
