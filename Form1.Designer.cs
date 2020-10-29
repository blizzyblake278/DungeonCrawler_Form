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
            this.dt_Picker.Location = new System.Drawing.Point(205, 189);
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
            this.lblDTpicker.Location = new System.Drawing.Point(112, 189);
            this.lblDTpicker.Name = "lblDTpicker";
            this.lblDTpicker.Size = new System.Drawing.Size(50, 15);
            this.lblDTpicker.TabIndex = 5;
            this.lblDTpicker.Text = "Birthday:";
            // 
            // btnContinue
            // 
            this.btnContinue.FlatAppearance.BorderSize = 3;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Location = new System.Drawing.Point(269, 267);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 363);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblDTpicker);
            this.Controls.Add(this.dt_Picker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
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
    }
}

