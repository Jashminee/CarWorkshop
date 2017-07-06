namespace CarWorkshop
{
    partial class WorkerMainWindow
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
            this.Search_Button = new System.Windows.Forms.Button();
            this.Activity_DataGridView = new System.Windows.Forms.DataGridView();
            this.Status_ComboBox = new System.Windows.Forms.ComboBox();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Show_Button = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LogOut_Button = new System.Windows.Forms.Button();
            this.WelcomeText_Label = new System.Windows.Forms.Label();
            this.Timeout_label = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(651, 31);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(121, 21);
            this.Search_Button.TabIndex = 3;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Activity_DataGridView
            // 
            this.Activity_DataGridView.AllowUserToAddRows = false;
            this.Activity_DataGridView.AllowUserToDeleteRows = false;
            this.Activity_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Activity_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Type,
            this.DateRequest,
            this.dateFinCancel,
            this.Status,
            this.Result});
            this.Activity_DataGridView.Location = new System.Drawing.Point(12, 59);
            this.Activity_DataGridView.MultiSelect = false;
            this.Activity_DataGridView.Name = "Activity_DataGridView";
            this.Activity_DataGridView.ReadOnly = true;
            this.Activity_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Activity_DataGridView.Size = new System.Drawing.Size(760, 365);
            this.Activity_DataGridView.TabIndex = 4;
            // 
            // Status_ComboBox
            // 
            this.Status_ComboBox.FormattingEnabled = true;
            this.Status_ComboBox.Location = new System.Drawing.Point(414, 30);
            this.Status_ComboBox.Name = "Status_ComboBox";
            this.Status_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Status_ComboBox.TabIndex = 2;
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(355, 35);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(37, 13);
            this.Status_Label.TabIndex = 24;
            this.Status_Label.Text = "Status";
            // 
            // Show_Button
            // 
            this.Show_Button.Location = new System.Drawing.Point(651, 430);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(121, 26);
            this.Show_Button.TabIndex = 5;
            this.Show_Button.Text = "Details";
            this.Show_Button.UseVisualStyleBackColor = true;
            this.Show_Button.Click += new System.EventHandler(this.Show_Button_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "DD.MM.YYYY";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(86, 31);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.ShowCheckBox = true;
            this.DateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.DateTimePicker.TabIndex = 1;
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.Location = new System.Drawing.Point(697, 2);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.Size = new System.Drawing.Size(75, 23);
            this.LogOut_Button.TabIndex = 6;
            this.LogOut_Button.Text = "Log out";
            this.LogOut_Button.UseVisualStyleBackColor = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // WelcomeText_Label
            // 
            this.WelcomeText_Label.AutoSize = true;
            this.WelcomeText_Label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WelcomeText_Label.Location = new System.Drawing.Point(9, 7);
            this.WelcomeText_Label.Name = "WelcomeText_Label";
            this.WelcomeText_Label.Size = new System.Drawing.Size(55, 13);
            this.WelcomeText_Label.TabIndex = 43;
            this.WelcomeText_Label.Text = "Welcome!";
            // 
            // Timeout_label
            // 
            this.Timeout_label.AutoSize = true;
            this.Timeout_label.Location = new System.Drawing.Point(29, 35);
            this.Timeout_label.Name = "Timeout_label";
            this.Timeout_label.Size = new System.Drawing.Size(50, 13);
            this.Timeout_label.TabIndex = 44;
            this.Timeout_label.Text = "Time Out";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // DateRequest
            // 
            this.DateRequest.HeaderText = "Date Request";
            this.DateRequest.Name = "DateRequest";
            this.DateRequest.ReadOnly = true;
            // 
            // dateFinCancel
            // 
            this.dateFinCancel.HeaderText = "Date finish";
            this.dateFinCancel.Name = "dateFinCancel";
            this.dateFinCancel.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // WorkerMainWindow
            // 
            this.AcceptButton = this.Search_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Timeout_label);
            this.Controls.Add(this.WelcomeText_Label);
            this.Controls.Add(this.LogOut_Button);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Show_Button);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Status_ComboBox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Activity_DataGridView);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "WorkerMainWindow";
            this.Text = "WorkerMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.Activity_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.DataGridView Activity_DataGridView;
        private System.Windows.Forms.ComboBox Status_ComboBox;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Button Show_Button;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button LogOut_Button;
        private System.Windows.Forms.Label WelcomeText_Label;
        private System.Windows.Forms.Label Timeout_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}