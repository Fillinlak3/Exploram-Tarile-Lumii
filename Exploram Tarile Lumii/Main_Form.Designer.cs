namespace Exploram_Tarile_Lumii
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Scene_MainMenu = new Scenes.Main_Menu();
            Scene_SelectGamemode = new Scenes.SelectGamemode();
            SuspendLayout();
            // 
            // Scene_MainMenu
            // 
            Scene_MainMenu.AutoSize = true;
            Scene_MainMenu.BackColor = Color.Transparent;
            Scene_MainMenu.Location = new Point(50, 50);
            Scene_MainMenu.Name = "Scene_MainMenu";
            Scene_MainMenu.Size = new Size(1820, 980);
            Scene_MainMenu.TabIndex = 0;
            // 
            // Scene_SelectGamemode
            // 
            Scene_SelectGamemode.AutoSize = true;
            Scene_SelectGamemode.BackColor = Color.Transparent;
            Scene_SelectGamemode.Location = new Point(50, 50);
            Scene_SelectGamemode.Name = "Scene_SelectGamemode";
            Scene_SelectGamemode.Size = new Size(1820, 980);
            Scene_SelectGamemode.TabIndex = 1;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.game_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1055);
            Controls.Add(Scene_MainMenu);
            Controls.Add(Scene_SelectGamemode);
            DoubleBuffered = true;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exploram Tarile Lumii";
            WindowState = FormWindowState.Maximized;
            Load += Main_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public static Scenes.Main_Menu Scene_MainMenu;
        public static Scenes.SelectGamemode Scene_SelectGamemode;
    }
}