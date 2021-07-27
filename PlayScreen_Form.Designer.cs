
namespace Trivia_Star
{
    partial class PlayScree_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayScree_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReadyToStartPanel = new System.Windows.Forms.Panel();
            this.ReadyToStartPanel_Expand = new System.Windows.Forms.Panel();
            this.BackButtonPanel = new System.Windows.Forms.Button();
            this.StartButtonPanel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RedButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.LabelAnswer = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer60Counter = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.ReadyToStartPanel.SuspendLayout();
            this.ReadyToStartPanel_Expand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ReadyToStartPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RedButton);
            this.panel1.Controls.Add(this.YellowButton);
            this.panel1.Controls.Add(this.GreenButton);
            this.panel1.Controls.Add(this.BlueButton);
            this.panel1.Controls.Add(this.LabelAnswer);
            this.panel1.Controls.Add(this.QuestionLabel);
            this.panel1.Controls.Add(this.TimerLabel);
            this.panel1.Controls.Add(this.PointsLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // ReadyToStartPanel
            // 
            this.ReadyToStartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReadyToStartPanel.Controls.Add(this.ReadyToStartPanel_Expand);
            this.ReadyToStartPanel.Location = new System.Drawing.Point(31, 22);
            this.ReadyToStartPanel.Name = "ReadyToStartPanel";
            this.ReadyToStartPanel.Size = new System.Drawing.Size(739, 407);
            this.ReadyToStartPanel.TabIndex = 11;
            // 
            // ReadyToStartPanel_Expand
            // 
            this.ReadyToStartPanel_Expand.Controls.Add(this.BackButtonPanel);
            this.ReadyToStartPanel_Expand.Controls.Add(this.StartButtonPanel);
            this.ReadyToStartPanel_Expand.Controls.Add(this.label7);
            this.ReadyToStartPanel_Expand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadyToStartPanel_Expand.Location = new System.Drawing.Point(0, 0);
            this.ReadyToStartPanel_Expand.Name = "ReadyToStartPanel_Expand";
            this.ReadyToStartPanel_Expand.Size = new System.Drawing.Size(739, 407);
            this.ReadyToStartPanel_Expand.TabIndex = 0;
            // 
            // BackButtonPanel
            // 
            this.BackButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackButtonPanel.FlatAppearance.BorderSize = 0;
            this.BackButtonPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButtonPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackButtonPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackButtonPanel.Location = new System.Drawing.Point(380, 220);
            this.BackButtonPanel.Name = "BackButtonPanel";
            this.BackButtonPanel.Size = new System.Drawing.Size(215, 41);
            this.BackButtonPanel.TabIndex = 4;
            this.BackButtonPanel.Text = "Back";
            this.BackButtonPanel.UseVisualStyleBackColor = false;
            this.BackButtonPanel.Click += new System.EventHandler(this.BackButtonPanel_Click);
            // 
            // StartButtonPanel
            // 
            this.StartButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartButtonPanel.FlatAppearance.BorderSize = 0;
            this.StartButtonPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButtonPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartButtonPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StartButtonPanel.Location = new System.Drawing.Point(143, 220);
            this.StartButtonPanel.Name = "StartButtonPanel";
            this.StartButtonPanel.Size = new System.Drawing.Size(215, 41);
            this.StartButtonPanel.TabIndex = 3;
            this.StartButtonPanel.Text = "Start";
            this.StartButtonPanel.UseVisualStyleBackColor = false;
            this.StartButtonPanel.Click += new System.EventHandler(this.StartButtonPanel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(260, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Are you ready to start?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.FlatAppearance.BorderSize = 0;
            this.RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedButton.Location = new System.Drawing.Point(50, 335);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(317, 44);
            this.RedButton.TabIndex = 9;
            this.RedButton.Text = "France";
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Gold;
            this.YellowButton.FlatAppearance.BorderSize = 0;
            this.YellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YellowButton.Location = new System.Drawing.Point(386, 335);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(328, 44);
            this.YellowButton.TabIndex = 8;
            this.YellowButton.Text = "Germany";
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GreenButton.FlatAppearance.BorderSize = 0;
            this.GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenButton.Location = new System.Drawing.Point(386, 260);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(328, 44);
            this.GreenButton.TabIndex = 7;
            this.GreenButton.Text = "Brazil";
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BlueButton.FlatAppearance.BorderSize = 0;
            this.BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueButton.Location = new System.Drawing.Point(50, 260);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(317, 44);
            this.BlueButton.TabIndex = 6;
            this.BlueButton.Text = "Uruguay";
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // LabelAnswer
            // 
            this.LabelAnswer.AutoSize = true;
            this.LabelAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.LabelAnswer.Location = new System.Drawing.Point(323, 399);
            this.LabelAnswer.Name = "LabelAnswer";
            this.LabelAnswer.Size = new System.Drawing.Size(108, 23);
            this.LabelAnswer.TabIndex = 5;
            this.LabelAnswer.Text = "<ANSWER>";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.QuestionLabel.Location = new System.Drawing.Point(92, 106);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(351, 46);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "1. What country won the very first FIFA\r\nworld cup in 1930?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.TimerLabel.Location = new System.Drawing.Point(127, 48);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(32, 22);
            this.TimerLabel.TabIndex = 3;
            this.TimerLabel.Text = "30";
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.PointsLabel.Location = new System.Drawing.Point(130, 15);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(21, 22);
            this.PointsLabel.TabIndex = 2;
            this.PointsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(63, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // timer60Counter
            // 
            this.timer60Counter.Interval = 1000;
            this.timer60Counter.Tick += new System.EventHandler(this.timer60Counter_Tick);
            // 
            // PlayScree_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayScree_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Screen";
            this.Load += new System.EventHandler(this.PlayScree_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ReadyToStartPanel.ResumeLayout(false);
            this.ReadyToStartPanel_Expand.ResumeLayout(false);
            this.ReadyToStartPanel_Expand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label LabelAnswer;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ReadyToStartPanel;
        private System.Windows.Forms.Panel ReadyToStartPanel_Expand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BackButtonPanel;
        private System.Windows.Forms.Button StartButtonPanel;
        private System.Windows.Forms.Timer timer60Counter;
    }
}