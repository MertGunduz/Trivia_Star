
namespace Trivia_Star
{
    partial class WellDoneScreen_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WellDoneScreen_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayerDetailsPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SubmitButtonPlayerDetails = new System.Windows.Forms.Button();
            this.BackButtonPlayerDetails = new System.Windows.Forms.Button();
            this.OtherRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.IDNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AgeNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.NameSurnameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerDetailsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.PlayerDetailsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.PlayerDetailsPanel);
            this.panel1.Controls.Add(this.PlayerDetailsButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.PlayAgainButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // PlayerDetailsPanel
            // 
            this.PlayerDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(55)))), ((int)(((byte)(27)))));
            this.PlayerDetailsPanel.Controls.Add(this.panel3);
            this.PlayerDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayerDetailsPanel.Name = "PlayerDetailsPanel";
            this.PlayerDetailsPanel.Size = new System.Drawing.Size(800, 450);
            this.PlayerDetailsPanel.TabIndex = 7;
            this.PlayerDetailsPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 426);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SubmitButtonPlayerDetails);
            this.panel4.Controls.Add(this.BackButtonPlayerDetails);
            this.panel4.Controls.Add(this.OtherRadioButton);
            this.panel4.Controls.Add(this.FemaleRadioButton);
            this.panel4.Controls.Add(this.MaleRadioButton);
            this.panel4.Controls.Add(this.IDNumberMaskedTextBox);
            this.panel4.Controls.Add(this.AgeNumericUpdown);
            this.panel4.Controls.Add(this.NameSurnameTextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 426);
            this.panel4.TabIndex = 0;
            // 
            // SubmitButtonPlayerDetails
            // 
            this.SubmitButtonPlayerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubmitButtonPlayerDetails.FlatAppearance.BorderSize = 0;
            this.SubmitButtonPlayerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButtonPlayerDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SubmitButtonPlayerDetails.ForeColor = System.Drawing.Color.White;
            this.SubmitButtonPlayerDetails.Location = new System.Drawing.Point(400, 361);
            this.SubmitButtonPlayerDetails.Name = "SubmitButtonPlayerDetails";
            this.SubmitButtonPlayerDetails.Size = new System.Drawing.Size(278, 30);
            this.SubmitButtonPlayerDetails.TabIndex = 14;
            this.SubmitButtonPlayerDetails.Text = "Submit";
            this.SubmitButtonPlayerDetails.UseVisualStyleBackColor = false;
            this.SubmitButtonPlayerDetails.Click += new System.EventHandler(this.SubmitButtonPlayerDetails_Click);
            // 
            // BackButtonPlayerDetails
            // 
            this.BackButtonPlayerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackButtonPlayerDetails.FlatAppearance.BorderSize = 0;
            this.BackButtonPlayerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButtonPlayerDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackButtonPlayerDetails.ForeColor = System.Drawing.Color.White;
            this.BackButtonPlayerDetails.Location = new System.Drawing.Point(113, 361);
            this.BackButtonPlayerDetails.Name = "BackButtonPlayerDetails";
            this.BackButtonPlayerDetails.Size = new System.Drawing.Size(278, 30);
            this.BackButtonPlayerDetails.TabIndex = 12;
            this.BackButtonPlayerDetails.Text = "Back";
            this.BackButtonPlayerDetails.UseVisualStyleBackColor = false;
            this.BackButtonPlayerDetails.Click += new System.EventHandler(this.BackButtonPlayerDetails_Click);
            // 
            // OtherRadioButton
            // 
            this.OtherRadioButton.AutoSize = true;
            this.OtherRadioButton.Location = new System.Drawing.Point(604, 275);
            this.OtherRadioButton.Name = "OtherRadioButton";
            this.OtherRadioButton.Size = new System.Drawing.Size(74, 25);
            this.OtherRadioButton.TabIndex = 10;
            this.OtherRadioButton.TabStop = true;
            this.OtherRadioButton.Text = "Other";
            this.OtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(454, 275);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(85, 25);
            this.FemaleRadioButton.TabIndex = 9;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(324, 275);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(67, 25);
            this.MaleRadioButton.TabIndex = 8;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // IDNumberMaskedTextBox
            // 
            this.IDNumberMaskedTextBox.Location = new System.Drawing.Point(324, 219);
            this.IDNumberMaskedTextBox.Mask = "000000L";
            this.IDNumberMaskedTextBox.Name = "IDNumberMaskedTextBox";
            this.IDNumberMaskedTextBox.Size = new System.Drawing.Size(354, 27);
            this.IDNumberMaskedTextBox.TabIndex = 7;
            // 
            // AgeNumericUpdown
            // 
            this.AgeNumericUpdown.Location = new System.Drawing.Point(324, 167);
            this.AgeNumericUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AgeNumericUpdown.Name = "AgeNumericUpdown";
            this.AgeNumericUpdown.Size = new System.Drawing.Size(354, 27);
            this.AgeNumericUpdown.TabIndex = 6;
            this.AgeNumericUpdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NameSurnameTextBox
            // 
            this.NameSurnameTextBox.Location = new System.Drawing.Point(324, 113);
            this.NameSurnameTextBox.Name = "NameSurnameTextBox";
            this.NameSurnameTextBox.Size = new System.Drawing.Size(354, 27);
            this.NameSurnameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(109, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(109, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name and Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chiller", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Player Details -";
            // 
            // PlayerDetailsButton
            // 
            this.PlayerDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayerDetailsButton.FlatAppearance.BorderSize = 0;
            this.PlayerDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerDetailsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlayerDetailsButton.ForeColor = System.Drawing.Color.White;
            this.PlayerDetailsButton.Location = new System.Drawing.Point(293, 326);
            this.PlayerDetailsButton.Name = "PlayerDetailsButton";
            this.PlayerDetailsButton.Size = new System.Drawing.Size(215, 41);
            this.PlayerDetailsButton.TabIndex = 6;
            this.PlayerDetailsButton.Text = "Player Details";
            this.PlayerDetailsButton.UseVisualStyleBackColor = false;
            this.PlayerDetailsButton.Click += new System.EventHandler(this.PlayerDetailsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(293, 373);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(215, 41);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayAgainButton.FlatAppearance.BorderSize = 0;
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.White;
            this.PlayAgainButton.Location = new System.Drawing.Point(293, 279);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(215, 41);
            this.PlayAgainButton.TabIndex = 4;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this.AgeNumericUpdown;
            // 
            // WellDoneScreen_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WellDoneScreen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Well Done";
            this.Load += new System.EventHandler(this.WellDoneScreen_Form_Load);
            this.panel1.ResumeLayout(false);
            this.PlayerDetailsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Button PlayerDetailsButton;
        private System.Windows.Forms.Panel PlayerDetailsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OtherRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.MaskedTextBox IDNumberMaskedTextBox;
        private System.Windows.Forms.NumericUpDown AgeNumericUpdown;
        private System.Windows.Forms.TextBox NameSurnameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButtonPlayerDetails;
        private System.Windows.Forms.Button BackButtonPlayerDetails;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}