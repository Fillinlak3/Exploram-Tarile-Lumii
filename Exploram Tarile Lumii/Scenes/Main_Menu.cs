using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploram_Tarile_Lumii.Scenes
{
    public partial class Main_Menu : UserControl
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void SelectGamemode(object sender, EventArgs e)
        {
            Main_Form.HideAllViews();
            Main_Form.Scene_SelectGamemode.Visible = true;
        }

        private void QuitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
