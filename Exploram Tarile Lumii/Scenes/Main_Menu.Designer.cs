namespace Exploram_Tarile_Lumii.Scenes
{
    partial class Main_Menu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_GameLogo = new PictureBox();
            BTN_Quit = new Button();
            BTN_Settings = new Button();
            BTN_Play = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_GameLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_GameLogo
            // 
            pictureBox_GameLogo.BackgroundImage = Properties.Resources.main_menu_logo;
            pictureBox_GameLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_GameLogo.Location = new Point(425, 100);
            pictureBox_GameLogo.Name = "pictureBox_GameLogo";
            pictureBox_GameLogo.Size = new Size(970, 180);
            pictureBox_GameLogo.TabIndex = 4;
            pictureBox_GameLogo.TabStop = false;
            // 
            // BTN_Quit
            // 
            BTN_Quit.BackColor = Color.Lime;
            BTN_Quit.Cursor = Cursors.Hand;
            BTN_Quit.FlatAppearance.BorderSize = 0;
            BTN_Quit.FlatStyle = FlatStyle.Flat;
            BTN_Quit.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Quit.Location = new Point(767, 600);
            BTN_Quit.Name = "BTN_Quit";
            BTN_Quit.Size = new Size(285, 80);
            BTN_Quit.TabIndex = 5;
            BTN_Quit.TabStop = false;
            BTN_Quit.Text = "Quit";
            BTN_Quit.UseVisualStyleBackColor = false;
            BTN_Quit.Click += QuitGame;
            // 
            // BTN_Settings
            // 
            BTN_Settings.BackColor = Color.Lime;
            BTN_Settings.Cursor = Cursors.Hand;
            BTN_Settings.FlatAppearance.BorderSize = 0;
            BTN_Settings.FlatStyle = FlatStyle.Flat;
            BTN_Settings.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Settings.Location = new Point(737, 500);
            BTN_Settings.Name = "BTN_Settings";
            BTN_Settings.Size = new Size(345, 80);
            BTN_Settings.TabIndex = 6;
            BTN_Settings.TabStop = false;
            BTN_Settings.Text = "Settings";
            BTN_Settings.UseVisualStyleBackColor = false;
            // 
            // BTN_Play
            // 
            BTN_Play.BackColor = Color.Lime;
            BTN_Play.Cursor = Cursors.Hand;
            BTN_Play.FlatAppearance.BorderSize = 0;
            BTN_Play.FlatStyle = FlatStyle.Flat;
            BTN_Play.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Play.Location = new Point(717, 400);
            BTN_Play.Name = "BTN_Play";
            BTN_Play.Size = new Size(385, 80);
            BTN_Play.TabIndex = 7;
            BTN_Play.TabStop = false;
            BTN_Play.Text = "Play";
            BTN_Play.UseVisualStyleBackColor = false;
            BTN_Play.Click += SelectGamemode;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(96, 332);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(480, 320);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(pictureBox4);
            Controls.Add(BTN_Quit);
            Controls.Add(BTN_Settings);
            Controls.Add(BTN_Play);
            Controls.Add(pictureBox_GameLogo);
            DoubleBuffered = true;
            Name = "Main_Menu";
            Size = new Size(1820, 980);
            ((System.ComponentModel.ISupportInitialize)pictureBox_GameLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_GameLogo;
        private Button BTN_Quit;
        private Button BTN_Settings;
        private Button BTN_Play;
        public PictureBox pictureBox4;
    }
}
