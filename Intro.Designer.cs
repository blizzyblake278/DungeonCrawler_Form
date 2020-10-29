namespace DungeonCrawler2
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.TxtBox1 = new System.Windows.Forms.RichTextBox();
            this.TxtBox2 = new System.Windows.Forms.RichTextBox();
            this.TxtBox3 = new System.Windows.Forms.RichTextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(12, 12);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(776, 109);
            this.TxtBox1.TabIndex = 0;
            this.TxtBox1.Text = resources.GetString("TxtBox1.Text");
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(12, 138);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(776, 109);
            this.TxtBox2.TabIndex = 1;
            this.TxtBox2.Text = resources.GetString("TxtBox2.Text");
            this.TxtBox2.Visible = false;
            // 
            // TxtBox3
            // 
            this.TxtBox3.Location = new System.Drawing.Point(12, 268);
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Size = new System.Drawing.Size(776, 109);
            this.TxtBox3.TabIndex = 2;
            this.TxtBox3.Text = resources.GetString("TxtBox3.Text");
            this.TxtBox3.Visible = false;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(358, 398);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(84, 40);
            this.ContinueButton.TabIndex = 3;
            this.ContinueButton.Text = "CONTINUE";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.TxtBox3);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Name = "Intro";
            this.Text = "Intro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtBox1;
        private System.Windows.Forms.RichTextBox TxtBox2;
        private System.Windows.Forms.RichTextBox TxtBox3;
        private System.Windows.Forms.Button ContinueButton;
    }
}