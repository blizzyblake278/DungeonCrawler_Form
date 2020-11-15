namespace DungeonCrawler2
{
    partial class Form1
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dt_Picker = new System.Windows.Forms.DateTimePicker();
            this.lblDTpicker = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.WarriorBox = new System.Windows.Forms.CheckBox();
            this.WizardBox = new System.Windows.Forms.CheckBox();
            this.Rangerbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Location = new System.Drawing.Point(115, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "EMAIL: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 50);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(73, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Character Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 127);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // dt_Picker
            // 
            this.dt_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Picker.Location = new System.Drawing.Point(180, 252);
            this.dt_Picker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_Picker.Name = "dt_Picker";
            this.dt_Picker.Size = new System.Drawing.Size(103, 20);
            this.dt_Picker.TabIndex = 4;
            this.dt_Picker.Value = new System.DateTime(2020, 10, 19, 0, 0, 0, 0);
            this.dt_Picker.ValueChanged += new System.EventHandler(this.Dt_Picker_ValueChanged);
            // 
            // lblDTpicker
            // 
            this.lblDTpicker.AutoSize = true;
            this.lblDTpicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDTpicker.Location = new System.Drawing.Point(115, 252);
            this.lblDTpicker.Name = "lblDTpicker";
            this.lblDTpicker.Size = new System.Drawing.Size(50, 15);
            this.lblDTpicker.TabIndex = 5;
            this.lblDTpicker.Text = "Birthday:";
            // 
            // btnContinue
            // 
            this.btnContinue.FlatAppearance.BorderSize = 3;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Location = new System.Drawing.Point(267, 299);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "&CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.Button1_Click);
            // 
            // WarriorBox
            // 
            this.WarriorBox.AutoSize = true;
            this.WarriorBox.Location = new System.Drawing.Point(180, 187);
            this.WarriorBox.Name = "WarriorBox";
            this.WarriorBox.Size = new System.Drawing.Size(79, 17);
            this.WarriorBox.TabIndex = 7;
            this.WarriorBox.Text = "WARRIOR";
            this.WarriorBox.UseVisualStyleBackColor = true;
            // 
            // WizardBox
            // 
            this.WizardBox.AutoSize = true;
            this.WizardBox.Location = new System.Drawing.Point(324, 187);
            this.WizardBox.Name = "WizardBox";
            this.WizardBox.Size = new System.Drawing.Size(70, 17);
            this.WizardBox.TabIndex = 8;
            this.WizardBox.Text = "WIZARD";
            this.WizardBox.UseVisualStyleBackColor = true;
            // 
            // Rangerbox
            // 
            this.Rangerbox.AutoSize = true;
            this.Rangerbox.Location = new System.Drawing.Point(454, 187);
            this.Rangerbox.Name = "Rangerbox";
            this.Rangerbox.Size = new System.Drawing.Size(72, 17);
            this.Rangerbox.TabIndex = 9;
            this.Rangerbox.Text = "RANGER";
            this.Rangerbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(112, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "CLASS:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "The Curse of Strahd_Save1";
            this.saveFileDialog1.Filter = "Excel|*.xlsx";
            this.saveFileDialog1.InitialDirectory = "%USERPROFILE%\\";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderSize = 3;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(358, 299);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "&REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 363);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rangerbox);
            this.Controls.Add(this.WizardBox);
            this.Controls.Add(this.WarriorBox);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblDTpicker);
            this.Controls.Add(this.dt_Picker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dt_Picker;
        private System.Windows.Forms.Label lblDTpicker;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.CheckBox WarriorBox;
        private System.Windows.Forms.CheckBox WizardBox;
        private System.Windows.Forms.CheckBox Rangerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRegister;
    }
}

