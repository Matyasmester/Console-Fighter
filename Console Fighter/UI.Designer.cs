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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LightHitButton
            // 
            this.LightHitButton.Location = new System.Drawing.Point(736, 96);
            this.LightHitButton.Margin = new System.Windows.Forms.Padding(4);
            this.LightHitButton.Name = "LightHitButton";
            this.LightHitButton.Size = new System.Drawing.Size(211, 100);
            this.LightHitButton.TabIndex = 0;
            this.LightHitButton.Text = "Light Hit";
            this.LightHitButton.UseVisualStyleBackColor = true;
            this.LightHitButton.Click += new System.EventHandler(this.LightHitButton_Click);
            // 
            // MediumHitButton
            // 
            this.MediumHitButton.Location = new System.Drawing.Point(736, 268);
            this.MediumHitButton.Margin = new System.Windows.Forms.Padding(4);
            this.MediumHitButton.Name = "MediumHitButton";
            this.MediumHitButton.Size = new System.Drawing.Size(211, 100);
            this.MediumHitButton.TabIndex = 1;
            this.MediumHitButton.Text = "Medium Hit";
            this.MediumHitButton.UseVisualStyleBackColor = true;
            this.MediumHitButton.Click += new System.EventHandler(this.MediumHitButton_Click);
            // 
            // HeavyHitButton
            // 
            this.HeavyHitButton.Location = new System.Drawing.Point(736, 441);
            this.HeavyHitButton.Margin = new System.Windows.Forms.Padding(4);
            this.HeavyHitButton.Name = "HeavyHitButton";
            this.HeavyHitButton.Size = new System.Drawing.Size(211, 98);
            this.HeavyHitButton.TabIndex = 2;
            this.HeavyHitButton.Text = "Heavy Hit";
            this.HeavyHitButton.UseVisualStyleBackColor = true;
            this.HeavyHitButton.Click += new System.EventHandler(this.HeavyHitButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(136, 42);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(95, 17);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "<status here>";
            // 
            // EasyDiffButton
            // 
            this.EasyDiffButton.Location = new System.Drawing.Point(461, 96);
            this.EasyDiffButton.Margin = new System.Windows.Forms.Padding(4);
            this.EasyDiffButton.Name = "EasyDiffButton";
            this.EasyDiffButton.Size = new System.Drawing.Size(201, 100);
            this.EasyDiffButton.TabIndex = 5;
            this.EasyDiffButton.Text = "Easy";
            this.EasyDiffButton.UseVisualStyleBackColor = true;
            // 
            // MediumDiffButton
            // 
            this.MediumDiffButton.Location = new System.Drawing.Point(461, 268);
            this.MediumDiffButton.Margin = new System.Windows.Forms.Padding(4);
            this.MediumDiffButton.Name = "MediumDiffButton";
            this.MediumDiffButton.Size = new System.Drawing.Size(201, 100);
            this.MediumDiffButton.TabIndex = 6;
            this.MediumDiffButton.Text = "Medium";
            this.MediumDiffButton.UseVisualStyleBackColor = true;
            this.MediumDiffButton.Click += new System.EventHandler(this.MediumDiffButton_Click);
            // 
            // HardDiffButton
            // 
            this.HardDiffButton.Location = new System.Drawing.Point(461, 441);
            this.HardDiffButton.Margin = new System.Windows.Forms.Padding(4);
            this.HardDiffButton.Name = "HardDiffButton";
            this.HardDiffButton.Size = new System.Drawing.Size(201, 98);
            this.HardDiffButton.TabIndex = 7;
            this.HardDiffButton.Text = "Hard";
            this.HardDiffButton.UseVisualStyleBackColor = true;
            this.HardDiffButton.Click += new System.EventHandler(this.HardDiffButton_Click);
            // 
            // Diff
            // 
            this.Diff.AutoSize = true;
            this.Diff.Location = new System.Drawing.Point(519, 42);
            this.Diff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(65, 17);
            this.Diff.TabIndex = 8;
            this.Diff.Text = "Difficulty:";
            // 
            // Hit
            // 
            this.Hit.AutoSize = true;
            this.Hit.Location = new System.Drawing.Point(813, 42);
            this.Hit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(36, 17);
            this.Hit.TabIndex = 9;
            this.Hit.Text = "Hits:";
            // 
            // EnemyHP
            // 
            this.EnemyHP.AutoSize = true;
            this.EnemyHP.Location = new System.Drawing.Point(4, 61);
            this.EnemyHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(74, 17);
            this.EnemyHP.TabIndex = 10;
            this.EnemyHP.Text = "EnemyHP:";
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Location = new System.Drawing.Point(4, 20);
            this.PlayerHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(71, 17);
            this.PlayerHP.TabIndex = 11;
            this.PlayerHP.Text = "PlayerHP:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EnemyHP);
            this.panel1.Controls.Add(this.PlayerHP);
            this.panel1.Location = new System.Drawing.Point(21, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 100);
            this.panel1.TabIndex = 13;
            // 
            // StatusTB
            // 
            this.StatusTB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StatusTB.Location = new System.Drawing.Point(21, 74);
            this.StatusTB.Multiline = true;
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(322, 329);
            this.StatusTB.TabIndex = 14;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1067, 567);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}