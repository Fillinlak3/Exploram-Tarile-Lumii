namespace Exploram_Tarile_Lumii.Scenes.Gamemodes
{
    partial class GuessTheFlag
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
            pictureBox_Flag = new PictureBox();
            BTN_Choice2 = new Button();
            BTN_Choice3 = new Button();
            BTN_Choice1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Flag).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Flag
            // 
            pictureBox_Flag.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_Flag.Location = new Point(670, 200);
            pictureBox_Flag.Name = "pictureBox_Flag";
            pictureBox_Flag.Size = new Size(480, 320);
            pictureBox_Flag.TabIndex = 9;
            pictureBox_Flag.TabStop = false;
            // 
            // BTN_Choice2
            // 
            BTN_Choice2.BackColor = Color.Lime;
            BTN_Choice2.Cursor = Cursors.Hand;
            BTN_Choice2.FlatAppearance.BorderSize = 0;
            BTN_Choice2.FlatStyle = FlatStyle.Flat;
            BTN_Choice2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Choice2.Location = new Point(685, 650);
            BTN_Choice2.Name = "BTN_Choice2";
            BTN_Choice2.Size = new Size(450, 80);
            BTN_Choice2.TabIndex = 10;
            BTN_Choice2.TabStop = false;
            BTN_Choice2.Text = "Country 2 here";
            BTN_Choice2.UseVisualStyleBackColor = false;
            BTN_Choice2.Click += CheckAnswer;
            // 
            // BTN_Choice3
            // 
            BTN_Choice3.BackColor = Color.Lime;
            BTN_Choice3.Cursor = Cursors.Hand;
            BTN_Choice3.FlatAppearance.BorderSize = 0;
            BTN_Choice3.FlatStyle = FlatStyle.Flat;
            BTN_Choice3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Choice3.Location = new Point(1270, 650);
            BTN_Choice3.Name = "BTN_Choice3";
            BTN_Choice3.Size = new Size(450, 80);
            BTN_Choice3.TabIndex = 11;
            BTN_Choice3.TabStop = false;
            BTN_Choice3.Text = "Country 3 here";
            BTN_Choice3.UseVisualStyleBackColor = false;
            BTN_Choice3.Click += CheckAnswer;
            // 
            // BTN_Choice1
            // 
            BTN_Choice1.BackColor = Color.Lime;
            BTN_Choice1.Cursor = Cursors.Hand;
            BTN_Choice1.FlatAppearance.BorderSize = 0;
            BTN_Choice1.FlatStyle = FlatStyle.Flat;
            BTN_Choice1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Choice1.Location = new Point(100, 650);
            BTN_Choice1.Name = "BTN_Choice1";
            BTN_Choice1.Size = new Size(450, 80);
            BTN_Choice1.TabIndex = 12;
            BTN_Choice1.TabStop = false;
            BTN_Choice1.Text = "Country 1 here";
            BTN_Choice1.UseVisualStyleBackColor = false;
            BTN_Choice1.Click += CheckAnswer;
            // 
            // GuessTheFlag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(BTN_Choice1);
            Controls.Add(BTN_Choice3);
            Controls.Add(BTN_Choice2);
            Controls.Add(pictureBox_Flag);
            DoubleBuffered = true;
            Name = "GuessTheFlag";
            Size = new Size(1820, 980);
            Load += Setup;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Flag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pictureBox_Flag;
        private Button BTN_Choice2;
        private Button BTN_Choice3;
        private Button BTN_Choice1;
    }
}
