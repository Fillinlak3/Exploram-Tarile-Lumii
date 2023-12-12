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
            Panel_Menu = new Panel();
            pictureBox_GameLogo = new PictureBox();
            BTN_Quit = new Button();
            BTN_Settings = new Button();
            BTN_Play = new Button();
            Panel_SelectGameMode = new Panel();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            Panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_GameLogo).BeginInit();
            Panel_SelectGameMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Panel_Menu
            // 
            Panel_Menu.BackColor = Color.Transparent;
            Panel_Menu.Controls.Add(pictureBox4);
            Panel_Menu.Controls.Add(pictureBox_GameLogo);
            Panel_Menu.Controls.Add(BTN_Quit);
            Panel_Menu.Controls.Add(BTN_Settings);
            Panel_Menu.Controls.Add(BTN_Play);
            Panel_Menu.Location = new Point(50, 50);
            Panel_Menu.Name = "Panel_Menu";
            Panel_Menu.Size = new Size(1820, 980);
            Panel_Menu.TabIndex = 0;
            // 
            // pictureBox_GameLogo
            // 
            pictureBox_GameLogo.BackgroundImage = Properties.Resources.main_menu_logo;
            pictureBox_GameLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_GameLogo.Location = new Point(425, 100);
            pictureBox_GameLogo.Name = "pictureBox_GameLogo";
            pictureBox_GameLogo.Size = new Size(970, 180);
            pictureBox_GameLogo.TabIndex = 3;
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
            BTN_Quit.TabIndex = 0;
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
            BTN_Settings.TabIndex = 0;
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
            BTN_Play.TabIndex = 0;
            BTN_Play.TabStop = false;
            BTN_Play.Text = "Play";
            BTN_Play.UseVisualStyleBackColor = false;
            BTN_Play.Click += SelectGamemode;
            // 
            // Panel_SelectGameMode
            // 
            Panel_SelectGameMode.BackColor = Color.Transparent;
            Panel_SelectGameMode.Controls.Add(pictureBox3);
            Panel_SelectGameMode.Controls.Add(button3);
            Panel_SelectGameMode.Controls.Add(button2);
            Panel_SelectGameMode.Controls.Add(pictureBox2);
            Panel_SelectGameMode.Controls.Add(button1);
            Panel_SelectGameMode.Controls.Add(pictureBox1);
            Panel_SelectGameMode.Location = new Point(50, 50);
            Panel_SelectGameMode.Name = "Panel_SelectGameMode";
            Panel_SelectGameMode.Size = new Size(1820, 980);
            Panel_SelectGameMode.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.world_games_logo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(425, 100);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(970, 180);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(737, 800);
            button3.Name = "button3";
            button3.Size = new Size(345, 80);
            button3.TabIndex = 4;
            button3.TabStop = false;
            button3.Text = "Return to Menu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += ReturnToMenu;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(560, 560);
            button2.Name = "button2";
            button2.Size = new Size(340, 80);
            button2.TabIndex = 3;
            button2.TabStop = false;
            button2.Text = "Flags";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.flags_selection_cover;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(530, 300);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 250);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(100, 560);
            button1.Name = "button1";
            button1.Size = new Size(340, 80);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "Capitals";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.capitals_selection_cover;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(70, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 250);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(161, 466);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(480, 240);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.game_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(Panel_Menu);
            Controls.Add(Panel_SelectGameMode);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exploram Tarile Lumii";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += Main_Form_Load;
            Panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_GameLogo).EndInit();
            Panel_SelectGameMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Menu;
        private Button BTN_Play;
        private Button BTN_Quit;
        private Button BTN_Settings;
        private PictureBox pictureBox_GameLogo;
        private Panel Panel_SelectGameMode;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}