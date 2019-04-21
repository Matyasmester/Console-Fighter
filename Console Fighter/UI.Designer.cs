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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.LightHitButton = new System.Windows.Forms.Button();
            this.MediumHitButton = new System.Windows.Forms.Button();
            this.HeavyHitButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.EasyDiffButton = new System.Windows.Forms.Button();
            this.MediumDiffButton = new System.Windows.Forms.Button();
            this.HardDiffButton = new System.Windows.Forms.Button();
            this.Diff = new System.Windows.Forms.Label();
            this.Hit = new System.Windows.Forms.Label();
            this.EnemyHP = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
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
            this.LightHitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MediumHitButton
            // 
            this.MediumHitButton.Location = new System.Drawing.Point(552, 218);
            this.MediumHitButton.Name = "MediumHitButton";
            this.MediumHitButton.Size = new System.Drawing.Size(158, 81);
            this.MediumHitButton.TabIndex = 1;
            this.MediumHitButton.Text = "Medium Hit";
            this.MediumHitButton.UseVisualStyleBackColor = true;
            // 
            // HeavyHitButton
            // 
            this.HeavyHitButton.Location = new System.Drawing.Point(552, 358);
            this.HeavyHitButton.Name = "HeavyHitButton";
            this.HeavyHitButton.Size = new System.Drawing.Size(158, 80);
            this.HeavyHitButton.TabIndex = 2;
            this.HeavyHitButton.Text = "Heavy Hit";
            this.HeavyHitButton.UseVisualStyleBackColor = true;
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
            // PicBox
            // 
            this.PicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicBox.InitialImage")));
            this.PicBox.Location = new System.Drawing.Point(66, 78);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(170, 200);
            this.PicBox.TabIndex = 4;
            this.PicBox.TabStop = false;
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
            this.EnemyHP.Location = new System.Drawing.Point(102, 372);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(57, 13);
            this.EnemyHP.TabIndex = 10;
            this.EnemyHP.Text = "EnemyHP:";
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Location = new System.Drawing.Point(102, 320);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(54, 13);
            this.PlayerHP.TabIndex = 11;
            this.PlayerHP.Text = "PlayerHP:";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.PlayerHP);
            this.Controls.Add(this.EnemyHP);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.HardDiffButton);
            this.Controls.Add(this.MediumDiffButton);
            this.Controls.Add(this.EasyDiffButton);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.HeavyHitButton);
            this.Controls.Add(this.MediumHitButton);
            this.Controls.Add(this.LightHitButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "UI";
            this.Text = "Console Fighter";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LightHitButton;
        private System.Windows.Forms.Button MediumHitButton;
        private System.Windows.Forms.Button HeavyHitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button EasyDiffButton;
        private System.Windows.Forms.Button MediumDiffButton;
        private System.Windows.Forms.Button HardDiffButton;
        private System.Windows.Forms.Label Diff;
        private System.Windows.Forms.Label Hit;
        private System.Windows.Forms.Label EnemyHP;
        private System.Windows.Forms.Label PlayerHP;
    }
}