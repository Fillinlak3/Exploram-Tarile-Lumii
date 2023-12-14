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
            pictureBox_Hint = new PictureBox();
            LB_Hint = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Flag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Hint).BeginInit();
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
            BTN_Choice2.BackColor = Color.White;
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
            BTN_Choice3.BackColor = Color.White;
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
            BTN_Choice1.BackColor = Color.White;
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
            // pictureBox_Hint
            // 
            pictureBox_Hint.BackgroundImage = Properties.Resources.hint_2;
            pictureBox_Hint.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_Hint.Cursor = Cursors.Help;
            pictureBox_Hint.Location = new Point(860, 780);
            pictureBox_Hint.Name = "pictureBox_Hint";
            pictureBox_Hint.Size = new Size(100, 100);
            pictureBox_Hint.TabIndex = 13;
            pictureBox_Hint.TabStop = false;
            pictureBox_Hint.Click += GetHint;
            // 
            // LB_Hint
            // 
            LB_Hint.AutoSize = true;
            LB_Hint.BackColor = Color.Gold;
            LB_Hint.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Hint.Location = new Point(822, 885);
            LB_Hint.Name = "LB_Hint";
            LB_Hint.Size = new Size(173, 38);
            LB_Hint.TabIndex = 14;
            LB_Hint.Text = "I'm the HINT";
            LB_Hint.Visible = false;
            // 
            // GuessTheFlag
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            Controls.Add(LB_Hint);
            Controls.Add(pictureBox_Hint);
            Controls.Add(BTN_Choice1);
            Controls.Add(BTN_Choice3);
            Controls.Add(BTN_Choice2);
            Controls.Add(pictureBox_Flag);
            DoubleBuffered = true;
            Name = "GuessTheFlag";
            Size = new Size(1820, 980);
            Load += Setup;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Flag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Hint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox_Flag;
        private Button BTN_Choice2;
        private Button BTN_Choice3;
        private Button BTN_Choice1;
        private PictureBox pictureBox_Hint;
        private Label LB_Hint;
    }
}
