namespace DungeonCrawler2
{
    partial class Encounter1
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
            this.AtkSword = new System.Windows.Forms.Button();
            this.AtkFist = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AtkSword
            // 
            this.AtkSword.Location = new System.Drawing.Point(195, 337);
            this.AtkSword.Name = "AtkSword";
            this.AtkSword.Size = new System.Drawing.Size(134, 34);
            this.AtkSword.TabIndex = 0;
            this.AtkSword.Text = "Attack w/ Hel Fire";
            this.AtkSword.UseVisualStyleBackColor = true;
            this.AtkSword.Click += new System.EventHandler(this.AtkSword_Click);
            // 
            // AtkFist
            // 
            this.AtkFist.Location = new System.Drawing.Point(454, 337);
            this.AtkFist.Name = "AtkFist";
            this.AtkFist.Size = new System.Drawing.Size(134, 34);
            this.AtkFist.TabIndex = 1;
            this.AtkFist.Text = "Attack w/ Fists";
            this.AtkFist.UseVisualStyleBackColor = true;
            this.AtkFist.Click += new System.EventHandler(this.AtkFist_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLabel.Location = new System.Drawing.Point(227, 107);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(79, 31);
            this.ResultsLabel.TabIndex = 2;
            this.ResultsLabel.Text = "label1";
            this.ResultsLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Which Way To Attack";
            // 
            // Encounter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.AtkFist);
            this.Controls.Add(this.AtkSword);
            this.Name = "Encounter1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encounter1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AtkSword;
        private System.Windows.Forms.Button AtkFist;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Label label1;
    }
}