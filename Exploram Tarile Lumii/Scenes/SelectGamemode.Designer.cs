namespace Exploram_Tarile_Lumii.Scenes
{
    partial class SelectGamemode
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
            pictureBox3 = new PictureBox();
            button3 = new Button();
            BTN_GuessTheFlags = new Button();
            pictureBox2 = new PictureBox();
            BTN_GuessTheCapitals = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.world_games_logo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(425, 100);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(970, 180);
            pictureBox3.TabIndex = 6;
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
            button3.TabIndex = 11;
            button3.TabStop = false;
            button3.Text = "Return to Menu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += ReturnToMenu;
            // 
            // BTN_GuessTheFlags
            // 
            BTN_GuessTheFlags.BackColor = Color.Lime;
            BTN_GuessTheFlags.Cursor = Cursors.Hand;
            BTN_GuessTheFlags.FlatAppearance.BorderSize = 0;
            BTN_GuessTheFlags.FlatStyle = FlatStyle.Flat;
            BTN_GuessTheFlags.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_GuessTheFlags.Location = new Point(560, 560);
            BTN_GuessTheFlags.Name = "BTN_GuessTheFlags";
            BTN_GuessTheFlags.Size = new Size(340, 80);
            BTN_GuessTheFlags.TabIndex = 10;
            BTN_GuessTheFlags.TabStop = false;
            BTN_GuessTheFlags.Text = "Flags";
            BTN_GuessTheFlags.UseVisualStyleBackColor = false;
            BTN_GuessTheFlags.Click += BTN_GuessTheFlags_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.flags_selection_cover;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(530, 300);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 250);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // BTN_GuessTheCapitals
            // 
            BTN_GuessTheCapitals.BackColor = Color.Lime;
            BTN_GuessTheCapitals.Cursor = Cursors.Hand;
            BTN_GuessTheCapitals.FlatAppearance.BorderSize = 0;
            BTN_GuessTheCapitals.FlatStyle = FlatStyle.Flat;
            BTN_GuessTheCapitals.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_GuessTheCapitals.Location = new Point(100, 560);
            BTN_GuessTheCapitals.Name = "BTN_GuessTheCapitals";
            BTN_GuessTheCapitals.Size = new Size(340, 80);
            BTN_GuessTheCapitals.TabIndex = 8;
            BTN_GuessTheCapitals.TabStop = false;
            BTN_GuessTheCapitals.Text = "Capitals";
            BTN_GuessTheCapitals.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.capitals_selection_cover;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(70, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 250);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // SelectGamemode
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(button3);
            Controls.Add(BTN_GuessTheFlags);
            Controls.Add(pictureBox2);
            Controls.Add(BTN_GuessTheCapitals);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            Name = "SelectGamemode";
            Size = new Size(1820, 980);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private Button button3;
        private Button BTN_GuessTheFlags;
        private PictureBox pictureBox2;
        private Button BTN_GuessTheCapitals;
        private PictureBox pictureBox1;
    }
}
