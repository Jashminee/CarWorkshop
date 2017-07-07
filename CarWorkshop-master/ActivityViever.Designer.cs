namespace CarWorkshop
{
    partial class ActivityViever
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
			this.Date_Label = new System.Windows.Forms.Label();
			this.ActivityDescription_TextBox = new System.Windows.Forms.TextBox();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.StartWork_Button = new System.Windows.Forms.Button();
			this.Finish_Button = new System.Windows.Forms.Button();
			this.WorkInProgres_GroupBox = new System.Windows.Forms.GroupBox();
			this.Return_Button = new System.Windows.Forms.Button();
			this.Result_Label = new System.Windows.Forms.Label();
			this.Result_TextBox = new System.Windows.Forms.TextBox();
			this.Object_GroupBox = new System.Windows.Forms.GroupBox();
			this.Name_TextBox = new System.Windows.Forms.TextBox();
			this.Name_Label = new System.Windows.Forms.Label();
			this.Year_TextBox = new System.Windows.Forms.TextBox();
			this.Engine_TextBox = new System.Windows.Forms.TextBox();
			this.RegistrationNumber_Label = new System.Windows.Forms.Label();
			this.BodyType_TextBox = new System.Windows.Forms.TextBox();
			this.Other_Label = new System.Windows.Forms.Label();
			this.Other_TextBox = new System.Windows.Forms.TextBox();
			this.BodyType_Label = new System.Windows.Forms.Label();
			this.Model_TextBox = new System.Windows.Forms.TextBox();
			this.Year_Label = new System.Windows.Forms.Label();
			this.Model_Label = new System.Windows.Forms.Label();
			this.Manufacturer_TextBox = new System.Windows.Forms.TextBox();
			this.Engine_Label = new System.Windows.Forms.Label();
			this.Manufacturer_Label = new System.Windows.Forms.Label();
			this.RegistrationNumber_TextBox = new System.Windows.Forms.TextBox();
			this.Activity_GroupBox = new System.Windows.Forms.GroupBox();
			this.ActivityDescription_Label = new System.Windows.Forms.Label();
			this.Status_Label = new System.Windows.Forms.Label();
			this.Date_TextBox = new System.Windows.Forms.TextBox();
			this.Status_TextBox = new System.Windows.Forms.TextBox();
			this.Request_GroupBox = new System.Windows.Forms.GroupBox();
			this.RequestDescription_Label = new System.Windows.Forms.Label();
			this.RequestDescription_TextBox = new System.Windows.Forms.TextBox();
			this.Save_Button = new System.Windows.Forms.Button();
			this.WorkInProgres_GroupBox.SuspendLayout();
			this.Object_GroupBox.SuspendLayout();
			this.Activity_GroupBox.SuspendLayout();
			this.Request_GroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// Date_Label
			// 
			this.Date_Label.AutoSize = true;
			this.Date_Label.Location = new System.Drawing.Point(255, 18);
			this.Date_Label.Name = "Date_Label";
			this.Date_Label.Size = new System.Drawing.Size(30, 13);
			this.Date_Label.TabIndex = 3;
			this.Date_Label.Text = "Date";
			// 
			// ActivityDescription_TextBox
			// 
			this.ActivityDescription_TextBox.Enabled = false;
			this.ActivityDescription_TextBox.Location = new System.Drawing.Point(26, 41);
			this.ActivityDescription_TextBox.Multiline = true;
			this.ActivityDescription_TextBox.Name = "ActivityDescription_TextBox";
			this.ActivityDescription_TextBox.Size = new System.Drawing.Size(204, 125);
			this.ActivityDescription_TextBox.TabIndex = 7;
			// 
			// Cancel_Button
			// 
			this.Cancel_Button.Location = new System.Drawing.Point(6, 19);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(125, 35);
			this.Cancel_Button.TabIndex = 9;
			this.Cancel_Button.Text = "Cancel";
			this.Cancel_Button.UseVisualStyleBackColor = true;
			this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
			// 
			// StartWork_Button
			// 
			this.StartWork_Button.Location = new System.Drawing.Point(137, 19);
			this.StartWork_Button.Name = "StartWork_Button";
			this.StartWork_Button.Size = new System.Drawing.Size(125, 35);
			this.StartWork_Button.TabIndex = 11;
			this.StartWork_Button.Text = "Start Work";
			this.StartWork_Button.UseVisualStyleBackColor = true;
			this.StartWork_Button.Click += new System.EventHandler(this.StartWork_Button_Click);
			// 
			// Finish_Button
			// 
			this.Finish_Button.Location = new System.Drawing.Point(268, 19);
			this.Finish_Button.Name = "Finish_Button";
			this.Finish_Button.Size = new System.Drawing.Size(125, 35);
			this.Finish_Button.TabIndex = 12;
			this.Finish_Button.Text = "Finish";
			this.Finish_Button.UseVisualStyleBackColor = true;
			this.Finish_Button.Click += new System.EventHandler(this.Finish_Button_Click);
			// 
			// WorkInProgres_GroupBox
			// 
			this.WorkInProgres_GroupBox.Controls.Add(this.Cancel_Button);
			this.WorkInProgres_GroupBox.Controls.Add(this.Finish_Button);
			this.WorkInProgres_GroupBox.Controls.Add(this.StartWork_Button);
			this.WorkInProgres_GroupBox.Location = new System.Drawing.Point(123, 443);
			this.WorkInProgres_GroupBox.Name = "WorkInProgres_GroupBox";
			this.WorkInProgres_GroupBox.Size = new System.Drawing.Size(415, 65);
			this.WorkInProgres_GroupBox.TabIndex = 13;
			this.WorkInProgres_GroupBox.TabStop = false;
			this.WorkInProgres_GroupBox.Text = "Status";
			// 
			// Return_Button
			// 
			this.Return_Button.Location = new System.Drawing.Point(20, 483);
			this.Return_Button.Name = "Return_Button";
			this.Return_Button.Size = new System.Drawing.Size(75, 25);
			this.Return_Button.TabIndex = 13;
			this.Return_Button.Text = "Return";
			this.Return_Button.UseVisualStyleBackColor = true;
			this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
			// 
			// Result_Label
			// 
			this.Result_Label.AutoSize = true;
			this.Result_Label.Location = new System.Drawing.Point(255, 44);
			this.Result_Label.Name = "Result_Label";
			this.Result_Label.Size = new System.Drawing.Size(37, 13);
			this.Result_Label.TabIndex = 17;
			this.Result_Label.Text = "Result";
			// 
			// Result_TextBox
			// 
			this.Result_TextBox.BackColor = System.Drawing.SystemColors.Control;
			this.Result_TextBox.Enabled = false;
			this.Result_TextBox.Location = new System.Drawing.Point(314, 41);
			this.Result_TextBox.Multiline = true;
			this.Result_TextBox.Name = "Result_TextBox";
			this.Result_TextBox.Size = new System.Drawing.Size(200, 99);
			this.Result_TextBox.TabIndex = 16;
			// 
			// Object_GroupBox
			// 
			this.Object_GroupBox.Controls.Add(this.Name_TextBox);
			this.Object_GroupBox.Controls.Add(this.Name_Label);
			this.Object_GroupBox.Controls.Add(this.Year_TextBox);
			this.Object_GroupBox.Controls.Add(this.Engine_TextBox);
			this.Object_GroupBox.Controls.Add(this.RegistrationNumber_Label);
			this.Object_GroupBox.Controls.Add(this.BodyType_TextBox);
			this.Object_GroupBox.Controls.Add(this.Other_Label);
			this.Object_GroupBox.Controls.Add(this.Other_TextBox);
			this.Object_GroupBox.Controls.Add(this.BodyType_Label);
			this.Object_GroupBox.Controls.Add(this.Model_TextBox);
			this.Object_GroupBox.Controls.Add(this.Year_Label);
			this.Object_GroupBox.Controls.Add(this.Model_Label);
			this.Object_GroupBox.Controls.Add(this.Manufacturer_TextBox);
			this.Object_GroupBox.Controls.Add(this.Engine_Label);
			this.Object_GroupBox.Controls.Add(this.Manufacturer_Label);
			this.Object_GroupBox.Controls.Add(this.RegistrationNumber_TextBox);
			this.Object_GroupBox.Location = new System.Drawing.Point(12, 12);
			this.Object_GroupBox.Name = "Object_GroupBox";
			this.Object_GroupBox.Size = new System.Drawing.Size(526, 134);
			this.Object_GroupBox.TabIndex = 19;
			this.Object_GroupBox.TabStop = false;
			this.Object_GroupBox.Text = "Object";
			// 
			// Name_TextBox
			// 
			this.Name_TextBox.Enabled = false;
			this.Name_TextBox.Location = new System.Drawing.Point(130, 45);
			this.Name_TextBox.Name = "Name_TextBox";
			this.Name_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Name_TextBox.TabIndex = 20;
			// 
			// Name_Label
			// 
			this.Name_Label.AutoSize = true;
			this.Name_Label.Location = new System.Drawing.Point(23, 48);
			this.Name_Label.Name = "Name_Label";
			this.Name_Label.Size = new System.Drawing.Size(35, 13);
			this.Name_Label.TabIndex = 19;
			this.Name_Label.Text = "Name";
			// 
			// Year_TextBox
			// 
			this.Year_TextBox.Enabled = false;
			this.Year_TextBox.Location = new System.Drawing.Point(314, 71);
			this.Year_TextBox.Name = "Year_TextBox";
			this.Year_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Year_TextBox.TabIndex = 18;
			// 
			// Engine_TextBox
			// 
			this.Engine_TextBox.Enabled = false;
			this.Engine_TextBox.Location = new System.Drawing.Point(314, 45);
			this.Engine_TextBox.Name = "Engine_TextBox";
			this.Engine_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Engine_TextBox.TabIndex = 17;
			// 
			// RegistrationNumber_Label
			// 
			this.RegistrationNumber_Label.AutoSize = true;
			this.RegistrationNumber_Label.Location = new System.Drawing.Point(23, 22);
			this.RegistrationNumber_Label.Name = "RegistrationNumber_Label";
			this.RegistrationNumber_Label.Size = new System.Drawing.Size(101, 13);
			this.RegistrationNumber_Label.TabIndex = 16;
			this.RegistrationNumber_Label.Text = "Registration number";
			// 
			// BodyType_TextBox
			// 
			this.BodyType_TextBox.Enabled = false;
			this.BodyType_TextBox.Location = new System.Drawing.Point(314, 19);
			this.BodyType_TextBox.Name = "BodyType_TextBox";
			this.BodyType_TextBox.Size = new System.Drawing.Size(100, 20);
			this.BodyType_TextBox.TabIndex = 15;
			// 
			// Other_Label
			// 
			this.Other_Label.AutoSize = true;
			this.Other_Label.Location = new System.Drawing.Point(255, 100);
			this.Other_Label.Name = "Other_Label";
			this.Other_Label.Size = new System.Drawing.Size(33, 13);
			this.Other_Label.TabIndex = 14;
			this.Other_Label.Text = "Other";
			// 
			// Other_TextBox
			// 
			this.Other_TextBox.Enabled = false;
			this.Other_TextBox.Location = new System.Drawing.Point(314, 97);
			this.Other_TextBox.Multiline = true;
			this.Other_TextBox.Name = "Other_TextBox";
			this.Other_TextBox.Size = new System.Drawing.Size(200, 20);
			this.Other_TextBox.TabIndex = 13;
			// 
			// BodyType_Label
			// 
			this.BodyType_Label.AutoSize = true;
			this.BodyType_Label.Location = new System.Drawing.Point(255, 22);
			this.BodyType_Label.Name = "BodyType_Label";
			this.BodyType_Label.Size = new System.Drawing.Size(54, 13);
			this.BodyType_Label.TabIndex = 12;
			this.BodyType_Label.Text = "Body type";
			// 
			// Model_TextBox
			// 
			this.Model_TextBox.Enabled = false;
			this.Model_TextBox.Location = new System.Drawing.Point(130, 97);
			this.Model_TextBox.Name = "Model_TextBox";
			this.Model_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Model_TextBox.TabIndex = 11;
			// 
			// Year_Label
			// 
			this.Year_Label.AutoSize = true;
			this.Year_Label.Location = new System.Drawing.Point(255, 74);
			this.Year_Label.Name = "Year_Label";
			this.Year_Label.Size = new System.Drawing.Size(29, 13);
			this.Year_Label.TabIndex = 10;
			this.Year_Label.Text = "Year";
			// 
			// Model_Label
			// 
			this.Model_Label.AutoSize = true;
			this.Model_Label.Location = new System.Drawing.Point(23, 100);
			this.Model_Label.Name = "Model_Label";
			this.Model_Label.Size = new System.Drawing.Size(36, 13);
			this.Model_Label.TabIndex = 8;
			this.Model_Label.Text = "Model";
			// 
			// Manufacturer_TextBox
			// 
			this.Manufacturer_TextBox.Enabled = false;
			this.Manufacturer_TextBox.Location = new System.Drawing.Point(130, 71);
			this.Manufacturer_TextBox.Name = "Manufacturer_TextBox";
			this.Manufacturer_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Manufacturer_TextBox.TabIndex = 7;
			// 
			// Engine_Label
			// 
			this.Engine_Label.AutoSize = true;
			this.Engine_Label.Location = new System.Drawing.Point(255, 48);
			this.Engine_Label.Name = "Engine_Label";
			this.Engine_Label.Size = new System.Drawing.Size(40, 13);
			this.Engine_Label.TabIndex = 6;
			this.Engine_Label.Text = "Engine";
			// 
			// Manufacturer_Label
			// 
			this.Manufacturer_Label.AutoSize = true;
			this.Manufacturer_Label.Location = new System.Drawing.Point(23, 74);
			this.Manufacturer_Label.Name = "Manufacturer_Label";
			this.Manufacturer_Label.Size = new System.Drawing.Size(70, 13);
			this.Manufacturer_Label.TabIndex = 4;
			this.Manufacturer_Label.Text = "Manufacturer";
			// 
			// RegistrationNumber_TextBox
			// 
			this.RegistrationNumber_TextBox.Enabled = false;
			this.RegistrationNumber_TextBox.Location = new System.Drawing.Point(130, 19);
			this.RegistrationNumber_TextBox.Name = "RegistrationNumber_TextBox";
			this.RegistrationNumber_TextBox.Size = new System.Drawing.Size(100, 20);
			this.RegistrationNumber_TextBox.TabIndex = 3;
			// 
			// Activity_GroupBox
			// 
			this.Activity_GroupBox.Controls.Add(this.ActivityDescription_Label);
			this.Activity_GroupBox.Controls.Add(this.Status_Label);
			this.Activity_GroupBox.Controls.Add(this.Date_TextBox);
			this.Activity_GroupBox.Controls.Add(this.Status_TextBox);
			this.Activity_GroupBox.Controls.Add(this.Result_TextBox);
			this.Activity_GroupBox.Controls.Add(this.Result_Label);
			this.Activity_GroupBox.Controls.Add(this.ActivityDescription_TextBox);
			this.Activity_GroupBox.Controls.Add(this.Date_Label);
			this.Activity_GroupBox.Location = new System.Drawing.Point(12, 253);
			this.Activity_GroupBox.Name = "Activity_GroupBox";
			this.Activity_GroupBox.Size = new System.Drawing.Size(526, 184);
			this.Activity_GroupBox.TabIndex = 20;
			this.Activity_GroupBox.TabStop = false;
			this.Activity_GroupBox.Text = "Activity";
			// 
			// ActivityDescription_Label
			// 
			this.ActivityDescription_Label.AutoSize = true;
			this.ActivityDescription_Label.Location = new System.Drawing.Point(23, 18);
			this.ActivityDescription_Label.Name = "ActivityDescription_Label";
			this.ActivityDescription_Label.Size = new System.Drawing.Size(60, 13);
			this.ActivityDescription_Label.TabIndex = 21;
			this.ActivityDescription_Label.Text = "Description";
			// 
			// Status_Label
			// 
			this.Status_Label.AutoSize = true;
			this.Status_Label.Location = new System.Drawing.Point(255, 149);
			this.Status_Label.Name = "Status_Label";
			this.Status_Label.Size = new System.Drawing.Size(37, 13);
			this.Status_Label.TabIndex = 20;
			this.Status_Label.Text = "Status";
			// 
			// Date_TextBox
			// 
			this.Date_TextBox.Enabled = false;
			this.Date_TextBox.Location = new System.Drawing.Point(314, 15);
			this.Date_TextBox.Name = "Date_TextBox";
			this.Date_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Date_TextBox.TabIndex = 19;
			// 
			// Status_TextBox
			// 
			this.Status_TextBox.Enabled = false;
			this.Status_TextBox.Location = new System.Drawing.Point(314, 146);
			this.Status_TextBox.Name = "Status_TextBox";
			this.Status_TextBox.ReadOnly = true;
			this.Status_TextBox.Size = new System.Drawing.Size(200, 20);
			this.Status_TextBox.TabIndex = 4;
			// 
			// Request_GroupBox
			// 
			this.Request_GroupBox.Controls.Add(this.RequestDescription_Label);
			this.Request_GroupBox.Controls.Add(this.RequestDescription_TextBox);
			this.Request_GroupBox.Location = new System.Drawing.Point(12, 152);
			this.Request_GroupBox.Name = "Request_GroupBox";
			this.Request_GroupBox.Size = new System.Drawing.Size(526, 95);
			this.Request_GroupBox.TabIndex = 21;
			this.Request_GroupBox.TabStop = false;
			this.Request_GroupBox.Text = "Request";
			// 
			// RequestDescription_Label
			// 
			this.RequestDescription_Label.AutoSize = true;
			this.RequestDescription_Label.Location = new System.Drawing.Point(23, 16);
			this.RequestDescription_Label.Name = "RequestDescription_Label";
			this.RequestDescription_Label.Size = new System.Drawing.Size(60, 13);
			this.RequestDescription_Label.TabIndex = 23;
			this.RequestDescription_Label.Text = "Description";
			// 
			// RequestDescription_TextBox
			// 
			this.RequestDescription_TextBox.Enabled = false;
			this.RequestDescription_TextBox.Location = new System.Drawing.Point(26, 32);
			this.RequestDescription_TextBox.Multiline = true;
			this.RequestDescription_TextBox.Name = "RequestDescription_TextBox";
			this.RequestDescription_TextBox.Size = new System.Drawing.Size(488, 46);
			this.RequestDescription_TextBox.TabIndex = 22;
			// 
			// Save_Button
			// 
			this.Save_Button.Location = new System.Drawing.Point(20, 443);
			this.Save_Button.Name = "Save_Button";
			this.Save_Button.Size = new System.Drawing.Size(75, 25);
			this.Save_Button.TabIndex = 22;
			this.Save_Button.Text = "Save";
			this.Save_Button.UseVisualStyleBackColor = true;
			this.Save_Button.Click += new System.EventHandler(this.button1_Click);
			// 
			// ActivityViever
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 521);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.Return_Button);
			this.Controls.Add(this.Request_GroupBox);
			this.Controls.Add(this.Activity_GroupBox);
			this.Controls.Add(this.Object_GroupBox);
			this.Controls.Add(this.WorkInProgres_GroupBox);
			this.MaximumSize = new System.Drawing.Size(560, 560);
			this.MinimumSize = new System.Drawing.Size(560, 560);
			this.Name = "ActivityViever";
			this.Text = "Activity Viever";
			this.Load += new System.EventHandler(this.ActivityViever_Load);
			this.WorkInProgres_GroupBox.ResumeLayout(false);
			this.Object_GroupBox.ResumeLayout(false);
			this.Object_GroupBox.PerformLayout();
			this.Activity_GroupBox.ResumeLayout(false);
			this.Activity_GroupBox.PerformLayout();
			this.Request_GroupBox.ResumeLayout(false);
			this.Request_GroupBox.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.TextBox ActivityDescription_TextBox;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button StartWork_Button;
        private System.Windows.Forms.Button Finish_Button;
        private System.Windows.Forms.GroupBox WorkInProgres_GroupBox;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.TextBox Result_TextBox;
        private System.Windows.Forms.GroupBox Object_GroupBox;
        private System.Windows.Forms.Label RegistrationNumber_Label;
        private System.Windows.Forms.TextBox BodyType_TextBox;
        private System.Windows.Forms.Label Other_Label;
        private System.Windows.Forms.TextBox Other_TextBox;
        private System.Windows.Forms.Label BodyType_Label;
        private System.Windows.Forms.TextBox Model_TextBox;
        private System.Windows.Forms.Label Year_Label;
        private System.Windows.Forms.Label Model_Label;
        private System.Windows.Forms.TextBox Manufacturer_TextBox;
        private System.Windows.Forms.Label Engine_Label;
        private System.Windows.Forms.Label Manufacturer_Label;
        private System.Windows.Forms.TextBox RegistrationNumber_TextBox;
        private System.Windows.Forms.TextBox Year_TextBox;
        private System.Windows.Forms.TextBox Engine_TextBox;
        private System.Windows.Forms.GroupBox Activity_GroupBox;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.TextBox Date_TextBox;
        private System.Windows.Forms.TextBox Status_TextBox;
        private System.Windows.Forms.Label ActivityDescription_Label;
        private System.Windows.Forms.GroupBox Request_GroupBox;
        private System.Windows.Forms.Label RequestDescription_Label;
        private System.Windows.Forms.TextBox RequestDescription_TextBox;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button Save_Button;
    }
}