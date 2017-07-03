namespace CarWorkshop
{
    partial class UserEditor
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
			this.Name_Label = new System.Windows.Forms.Label();
			this.Name_TextBox = new System.Windows.Forms.TextBox();
			this.Surname_TextBox = new System.Windows.Forms.TextBox();
			this.Surname_Label = new System.Windows.Forms.Label();
			this.DateRetire_Label = new System.Windows.Forms.Label();
			this.Username_TextBox = new System.Windows.Forms.TextBox();
			this.Username_Label = new System.Windows.Forms.Label();
			this.Role_Label = new System.Windows.Forms.Label();
			this.Role_ComboBox = new System.Windows.Forms.ComboBox();
			this.Save_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.Password_TextBox = new System.Windows.Forms.TextBox();
			this.Password_Label = new System.Windows.Forms.Label();
			this.Date_Retire = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// Name_Label
			// 
			this.Name_Label.AutoSize = true;
			this.Name_Label.Location = new System.Drawing.Point(12, 19);
			this.Name_Label.Name = "Name_Label";
			this.Name_Label.Size = new System.Drawing.Size(35, 13);
			this.Name_Label.TabIndex = 0;
			this.Name_Label.Text = "Name";
			// 
			// Name_TextBox
			// 
			this.Name_TextBox.Location = new System.Drawing.Point(82, 16);
			this.Name_TextBox.Name = "Name_TextBox";
			this.Name_TextBox.Size = new System.Drawing.Size(140, 20);
			this.Name_TextBox.TabIndex = 1;
			// 
			// Surname_TextBox
			// 
			this.Surname_TextBox.Location = new System.Drawing.Point(82, 42);
			this.Surname_TextBox.Name = "Surname_TextBox";
			this.Surname_TextBox.Size = new System.Drawing.Size(140, 20);
			this.Surname_TextBox.TabIndex = 2;
			// 
			// Surname_Label
			// 
			this.Surname_Label.AutoSize = true;
			this.Surname_Label.Location = new System.Drawing.Point(12, 45);
			this.Surname_Label.Name = "Surname_Label";
			this.Surname_Label.Size = new System.Drawing.Size(49, 13);
			this.Surname_Label.TabIndex = 2;
			this.Surname_Label.Text = "Surname";
			// 
			// DateRetire_Label
			// 
			this.DateRetire_Label.AutoSize = true;
			this.DateRetire_Label.Location = new System.Drawing.Point(12, 123);
			this.DateRetire_Label.Name = "DateRetire_Label";
			this.DateRetire_Label.Size = new System.Drawing.Size(56, 13);
			this.DateRetire_Label.TabIndex = 6;
			this.DateRetire_Label.Text = "Date retire";
			// 
			// Username_TextBox
			// 
			this.Username_TextBox.Location = new System.Drawing.Point(82, 68);
			this.Username_TextBox.Name = "Username_TextBox";
			this.Username_TextBox.Size = new System.Drawing.Size(140, 20);
			this.Username_TextBox.TabIndex = 3;
			// 
			// Username_Label
			// 
			this.Username_Label.AutoSize = true;
			this.Username_Label.Location = new System.Drawing.Point(12, 71);
			this.Username_Label.Name = "Username_Label";
			this.Username_Label.Size = new System.Drawing.Size(55, 13);
			this.Username_Label.TabIndex = 4;
			this.Username_Label.Text = "Username";
			// 
			// Role_Label
			// 
			this.Role_Label.AutoSize = true;
			this.Role_Label.Location = new System.Drawing.Point(12, 149);
			this.Role_Label.Name = "Role_Label";
			this.Role_Label.Size = new System.Drawing.Size(29, 13);
			this.Role_Label.TabIndex = 8;
			this.Role_Label.Text = "Role";
			// 
			// Role_ComboBox
			// 
			this.Role_ComboBox.FormattingEnabled = true;
			this.Role_ComboBox.Location = new System.Drawing.Point(82, 146);
			this.Role_ComboBox.Name = "Role_ComboBox";
			this.Role_ComboBox.Size = new System.Drawing.Size(140, 21);
			this.Role_ComboBox.TabIndex = 6;
			// 
			// Save_Button
			// 
			this.Save_Button.Location = new System.Drawing.Point(147, 176);
			this.Save_Button.Name = "Save_Button";
			this.Save_Button.Size = new System.Drawing.Size(75, 23);
			this.Save_Button.TabIndex = 8;
			this.Save_Button.Text = "Apply";
			this.Save_Button.UseVisualStyleBackColor = true;
			this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
			// 
			// Cancel_Button
			// 
			this.Cancel_Button.Location = new System.Drawing.Point(12, 176);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
			this.Cancel_Button.TabIndex = 7;
			this.Cancel_Button.Text = "Cancel";
			this.Cancel_Button.UseVisualStyleBackColor = true;
			this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
			// 
			// Password_TextBox
			// 
			this.Password_TextBox.Location = new System.Drawing.Point(82, 94);
			this.Password_TextBox.Name = "Password_TextBox";
			this.Password_TextBox.Size = new System.Drawing.Size(140, 20);
			this.Password_TextBox.TabIndex = 4;
			this.Password_TextBox.UseSystemPasswordChar = true;
			// 
			// Password_Label
			// 
			this.Password_Label.AutoSize = true;
			this.Password_Label.Location = new System.Drawing.Point(12, 97);
			this.Password_Label.Name = "Password_Label";
			this.Password_Label.Size = new System.Drawing.Size(53, 13);
			this.Password_Label.TabIndex = 13;
			this.Password_Label.Text = "Password";
			// 
			// Date_Retire
			// 
			this.Date_Retire.Checked = false;
			this.Date_Retire.Location = new System.Drawing.Point(82, 121);
			this.Date_Retire.Name = "Date_Retire";
			this.Date_Retire.ShowCheckBox = true;
			this.Date_Retire.Size = new System.Drawing.Size(200, 20);
			this.Date_Retire.TabIndex = 5;
			// 
			// UserEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 211);
			this.Controls.Add(this.Date_Retire);
			this.Controls.Add(this.Password_TextBox);
			this.Controls.Add(this.Password_Label);
			this.Controls.Add(this.Cancel_Button);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.Role_ComboBox);
			this.Controls.Add(this.Role_Label);
			this.Controls.Add(this.DateRetire_Label);
			this.Controls.Add(this.Username_TextBox);
			this.Controls.Add(this.Username_Label);
			this.Controls.Add(this.Surname_TextBox);
			this.Controls.Add(this.Surname_Label);
			this.Controls.Add(this.Name_TextBox);
			this.Controls.Add(this.Name_Label);
			this.MaximumSize = new System.Drawing.Size(310, 250);
			this.MinimumSize = new System.Drawing.Size(250, 250);
			this.Name = "UserEditor";
			this.Text = "UserEditor";
			this.Load += new System.EventHandler(this.UserEditor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label Surname_Label;
        private System.Windows.Forms.Label DateRetire_Label;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Role_Label;
        private System.Windows.Forms.ComboBox Role_ComboBox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.DateTimePicker Date_Retire;
    }
}