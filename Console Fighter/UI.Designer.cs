namespace Console_Fighter
{
    partial class UI
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
            this.LightHitButton = new System.Windows.Forms.Button();
            this.MediumHitButton = new System.Windows.Forms.Button();
            this.HeavyHitButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.EasyDiffButton = new System.Windows.Forms.Button();
            this.MediumDiffButton = new System.Windows.Forms.Button();
            this.HardDiffButton = new System.Windows.Forms.Button();
            this.Diff = new System.Windows.Forms.Label();
            this.Hit = new System.Windows.Forms.Label();
            this.EnemyHP = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StaminaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LightHitButton
            // 
            this.LightHitButton.Location = new System.Drawing.Point(552, 78);
            this.LightHitButton.Name = "LightHitButton";
            this.LightHitButton.Size = new System.Drawing.Size(158, 81);
            this.LightHitButton.TabIndex = 0;
            this.LightHitButton.Text = "Light Hit";
            this.LightHitButton.UseVisualStyleBackColor = true;
            this.LightHitButton.Click += new System.EventHandler(this.LightHitButton_Click);
            // 
            // MediumHitButton
            // 
            this.MediumHitButton.Location = new System.Drawing.Point(552, 218);
            this.MediumHitButton.Name = "MediumHitButton";
            this.MediumHitButton.Size = new System.Drawing.Size(158, 81);
            this.MediumHitButton.TabIndex = 1;
            this.MediumHitButton.Text = "Medium Hit";
            this.MediumHitButton.UseVisualStyleBackColor = true;
            this.MediumHitButton.Click += new System.EventHandler(this.MediumHitButton_Click);
            // 
            // HeavyHitButton
            // 
            this.HeavyHitButton.Location = new System.Drawing.Point(552, 358);
            this.HeavyHitButton.Name = "HeavyHitButton";
            this.HeavyHitButton.Size = new System.Drawing.Size(158, 80);
            this.HeavyHitButton.TabIndex = 2;
            this.HeavyHitButton.Text = "Heavy Hit";
            this.HeavyHitButton.UseVisualStyleBackColor = true;
            this.HeavyHitButton.Click += new System.EventHandler(this.HeavyHitButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(102, 34);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(71, 13);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "<status here>";
            // 
            // EasyDiffButton
            // 
            this.EasyDiffButton.Location = new System.Drawing.Point(346, 78);
            this.EasyDiffButton.Name = "EasyDiffButton";
            this.EasyDiffButton.Size = new System.Drawing.Size(151, 81);
            this.EasyDiffButton.TabIndex = 5;
            this.EasyDiffButton.Text = "Easy";
            this.EasyDiffButton.UseVisualStyleBackColor = true;
            // 
            // MediumDiffButton
            // 
            this.MediumDiffButton.Location = new System.Drawing.Point(346, 218);
            this.MediumDiffButton.Name = "MediumDiffButton";
            this.MediumDiffButton.Size = new System.Drawing.Size(151, 81);
            this.MediumDiffButton.TabIndex = 6;
            this.MediumDiffButton.Text = "Medium";
            this.MediumDiffButton.UseVisualStyleBackColor = true;
            this.MediumDiffButton.Click += new System.EventHandler(this.MediumDiffButton_Click);
            // 
            // HardDiffButton
            // 
            this.HardDiffButton.Location = new System.Drawing.Point(346, 358);
            this.HardDiffButton.Name = "HardDiffButton";
            this.HardDiffButton.Size = new System.Drawing.Size(151, 80);
            this.HardDiffButton.TabIndex = 7;
            this.HardDiffButton.Text = "Hard";
            this.HardDiffButton.UseVisualStyleBackColor = true;
            this.HardDiffButton.Click += new System.EventHandler(this.HardDiffButton_Click);
            // 
            // Diff
            // 
            this.Diff.AutoSize = true;
            this.Diff.Location = new System.Drawing.Point(389, 34);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(50, 13);
            this.Diff.TabIndex = 8;
            this.Diff.Text = "Difficulty:";
            // 
            // Hit
            // 
            this.Hit.AutoSize = true;
            this.Hit.Location = new System.Drawing.Point(610, 34);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(28, 13);
            this.Hit.TabIndex = 9;
            this.Hit.Text = "Hits:";
            // 
            // EnemyHP
            // 
            this.EnemyHP.AutoSize = true;
            this.EnemyHP.Location = new System.Drawing.Point(3, 50);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(57, 13);
            this.EnemyHP.TabIndex = 10;
            this.EnemyHP.Text = "EnemyHP:";
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Location = new System.Drawing.Point(3, 16);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(54, 13);
            this.PlayerHP.TabIndex = 11;
            this.PlayerHP.Text = "PlayerHP:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EnemyHP);
            this.panel1.Controls.Add(this.PlayerHP);
            this.panel1.Location = new System.Drawing.Point(16, 342);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 108);
            this.panel1.TabIndex = 13;
            // 
            // StatusTB
            // 
            this.StatusTB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StatusTB.Location = new System.Drawing.Point(16, 60);
            this.StatusTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusTB.Multiline = true;
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(242, 268);
            this.StatusTB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // StaminaLabel
            // 
            this.StaminaLabel.AutoSize = true;
            this.StaminaLabel.Location = new System.Drawing.Point(19, 425);
            this.StaminaLabel.Name = "StaminaLabel";
            this.StaminaLabel.Size = new System.Drawing.Size(51, 13);
            this.StaminaLabel.TabIndex = 16;
            this.StaminaLabel.Text = "Stamina: ";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.StaminaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.HardDiffButton);
            this.Controls.Add(this.MediumDiffButton);
            this.Controls.Add(this.EasyDiffButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.HeavyHitButton);
            this.Controls.Add(this.MediumHitButton);
            this.Controls.Add(this.LightHitButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "UI";
            this.Text = "Console Fighter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LightHitButton;
        private System.Windows.Forms.Button MediumHitButton;
        private System.Windows.Forms.Button HeavyHitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button EasyDiffButton;
        private System.Windows.Forms.Button MediumDiffButton;
        private System.Windows.Forms.Button HardDiffButton;
        private System.Windows.Forms.Label Diff;
        private System.Windows.Forms.Label Hit;
        private System.Windows.Forms.Label EnemyHP;
        private System.Windows.Forms.Label PlayerHP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox StatusTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StaminaLabel;
    }
}