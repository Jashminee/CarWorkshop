namespace CarWorkshop
{
    partial class AdminMainWindow
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
			this.Users_DataGridView = new System.Windows.Forms.DataGridView();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateRetire = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Surname_TextBox = new System.Windows.Forms.TextBox();
			this.Surname_Label = new System.Windows.Forms.Label();
			this.Name_Label = new System.Windows.Forms.Label();
			this.Name_TextBox = new System.Windows.Forms.TextBox();
			this.Role_Label = new System.Windows.Forms.Label();
			this.Role_ComboBox = new System.Windows.Forms.ComboBox();
			this.Search_Button = new System.Windows.Forms.Button();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.Edit_Button = new System.Windows.Forms.Button();
			this.AddNewAccount_Button = new System.Windows.Forms.Button();
			this.IncludeRetire_CheckBox = new System.Windows.Forms.CheckBox();
			this.LogOut_Button = new System.Windows.Forms.Button();
			this.WelcomeText_Label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Users_DataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// Users_DataGridView
			// 
			this.Users_DataGridView.AllowUserToAddRows = false;
			this.Users_DataGridView.AllowUserToDeleteRows = false;
			this.Users_DataGridView.AllowUserToResizeRows = false;
			this.Users_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Users_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Username,
            this.DateRetire,
            this.Role});
			this.Users_DataGridView.Location = new System.Drawing.Point(10, 84);
			this.Users_DataGridView.MultiSelect = false;
			this.Users_DataGridView.Name = "Users_DataGridView";
			this.Users_DataGridView.ReadOnly = true;
			this.Users_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Users_DataGridView.Size = new System.Drawing.Size(762, 336);
			this.Users_DataGridView.TabIndex = 6;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "Name";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.HeaderText = "Surname";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// Username
			// 
			this.Username.HeaderText = "Username";
			this.Username.Name = "Username";
			this.Username.ReadOnly = true;
			// 
			// DateRetire
			// 
			this.DateRetire.HeaderText = "Date retire";
			this.DateRetire.Name = "DateRetire";
			this.DateRetire.ReadOnly = true;
			// 
			// Role
			// 
			this.Role.HeaderText = "Role";
			this.Role.Name = "Role";
			this.Role.ReadOnly = true;
			// 
			// Surname_TextBox
			// 
			this.Surname_TextBox.Location = new System.Drawing.Point(270, 32);
			this.Surname_TextBox.Name = "Surname_TextBox";
			this.Surname_TextBox.Size = new System.Drawing.Size(150, 20);
			this.Surname_TextBox.TabIndex = 2;
			// 
			// Surname_Label
			// 
			this.Surname_Label.AutoSize = true;
			this.Surname_Label.Location = new System.Drawing.Point(215, 35);
			this.Surname_Label.Name = "Surname_Label";
			this.Surname_Label.Size = new System.Drawing.Size(49, 13);
			this.Surname_Label.TabIndex = 7;
			this.Surname_Label.Text = "Surname";
			// 
			// Name_Label
			// 
			this.Name_Label.AutoSize = true;
			this.Name_Label.Location = new System.Drawing.Point(7, 35);
			this.Name_Label.Name = "Name_Label";
			this.Name_Label.Size = new System.Drawing.Size(35, 13);
			this.Name_Label.TabIndex = 6;
			this.Name_Label.Text = "Name";
			// 
			// Name_TextBox
			// 
			this.Name_TextBox.Location = new System.Drawing.Point(48, 32);
			this.Name_TextBox.Name = "Name_TextBox";
			this.Name_TextBox.Size = new System.Drawing.Size(150, 20);
			this.Name_TextBox.TabIndex = 1;
			// 
			// Role_Label
			// 
			this.Role_Label.AutoSize = true;
			this.Role_Label.Location = new System.Drawing.Point(438, 35);
			this.Role_Label.Name = "Role_Label";
			this.Role_Label.Size = new System.Drawing.Size(29, 13);
			this.Role_Label.TabIndex = 10;
			this.Role_Label.Text = "Role";
			// 
			// Role_ComboBox
			// 
			this.Role_ComboBox.FormattingEnabled = true;
			this.Role_ComboBox.Location = new System.Drawing.Point(473, 32);
			this.Role_ComboBox.Name = "Role_ComboBox";
			this.Role_ComboBox.Size = new System.Drawing.Size(121, 21);
			this.Role_ComboBox.TabIndex = 3;
			// 
			// Search_Button
			// 
			this.Search_Button.Location = new System.Drawing.Point(651, 29);
			this.Search_Button.Name = "Search_Button";
			this.Search_Button.Size = new System.Drawing.Size(121, 23);
			this.Search_Button.TabIndex = 5;
			this.Search_Button.Text = "Search";
			this.Search_Button.UseVisualStyleBackColor = true;
			this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
			// 
			// Delete_Button
			// 
			this.Delete_Button.Location = new System.Drawing.Point(651, 426);
			this.Delete_Button.Name = "Delete_Button";
			this.Delete_Button.Size = new System.Drawing.Size(121, 23);
			this.Delete_Button.TabIndex = 9;
			this.Delete_Button.Text = "Delete";
			this.Delete_Button.UseVisualStyleBackColor = true;
			this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
			// 
			// Edit_Button
			// 
			this.Edit_Button.Location = new System.Drawing.Point(524, 426);
			this.Edit_Button.Name = "Edit_Button";
			this.Edit_Button.Size = new System.Drawing.Size(121, 23);
			this.Edit_Button.TabIndex = 8;
			this.Edit_Button.Text = "Edit";
			this.Edit_Button.UseVisualStyleBackColor = true;
			this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
			// 
			// AddNewAccount_Button
			// 
			this.AddNewAccount_Button.Location = new System.Drawing.Point(10, 426);
			this.AddNewAccount_Button.Name = "AddNewAccount_Button";
			this.AddNewAccount_Button.Size = new System.Drawing.Size(121, 23);
			this.AddNewAccount_Button.TabIndex = 7;
			this.AddNewAccount_Button.Text = "Add new account";
			this.AddNewAccount_Button.UseVisualStyleBackColor = true;
			this.AddNewAccount_Button.Click += new System.EventHandler(this.AddNewAccount_Button_Click);
			// 
			// IncludeRetire_CheckBox
			// 
			this.IncludeRetire_CheckBox.AutoSize = true;
			this.IncludeRetire_CheckBox.Location = new System.Drawing.Point(10, 61);
			this.IncludeRetire_CheckBox.Name = "IncludeRetire_CheckBox";
			this.IncludeRetire_CheckBox.Size = new System.Drawing.Size(93, 17);
			this.IncludeRetire_CheckBox.TabIndex = 4;
			this.IncludeRetire_CheckBox.Text = "Include retired";
			this.IncludeRetire_CheckBox.UseVisualStyleBackColor = true;
			// 
			// LogOut_Button
			// 
			this.LogOut_Button.Location = new System.Drawing.Point(716, 0);
			this.LogOut_Button.Name = "LogOut_Button";
			this.LogOut_Button.Size = new System.Drawing.Size(56, 23);
			this.LogOut_Button.TabIndex = 10;
			this.LogOut_Button.Text = "Log out";
			this.LogOut_Button.UseVisualStyleBackColor = true;
			this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
			// 
			// WelcomeText_Label
			// 
			this.WelcomeText_Label.AutoSize = true;
			this.WelcomeText_Label.ForeColor = System.Drawing.SystemColors.GrayText;
			this.WelcomeText_Label.Location = new System.Drawing.Point(7, 5);
			this.WelcomeText_Label.Name = "WelcomeText_Label";
			this.WelcomeText_Label.Size = new System.Drawing.Size(55, 13);
			this.WelcomeText_Label.TabIndex = 18;
			this.WelcomeText_Label.Text = "Welcome!";
			// 
			// AdminMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.WelcomeText_Label);
			this.Controls.Add(this.LogOut_Button);
			this.Controls.Add(this.IncludeRetire_CheckBox);
			this.Controls.Add(this.AddNewAccount_Button);
			this.Controls.Add(this.Edit_Button);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.Search_Button);
			this.Controls.Add(this.Role_ComboBox);
			this.Controls.Add(this.Role_Label);
			this.Controls.Add(this.Surname_TextBox);
			this.Controls.Add(this.Surname_Label);
			this.Controls.Add(this.Name_Label);
			this.Controls.Add(this.Name_TextBox);
			this.Controls.Add(this.Users_DataGridView);
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "AdminMainWindow";
			this.Text = "AdminMainWindow";
			this.Load += new System.EventHandler(this.AdminMainWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.Users_DataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Users_DataGridView;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label Surname_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label Role_Label;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRetire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button AddNewAccount_Button;
        private System.Windows.Forms.CheckBox IncludeRetire_CheckBox;
        private System.Windows.Forms.Button LogOut_Button;
        private System.Windows.Forms.Label WelcomeText_Label;
		private System.Windows.Forms.ComboBox Role_ComboBox;
	}
}