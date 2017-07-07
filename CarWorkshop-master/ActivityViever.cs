using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace CarWorkshop
{
    public partial class ActivityViever : Form
    {
        private Activity activity;

        public ActivityViever(Activity activity)
        {
            InitializeComponent();
            this.activity = activity;
            Request request = activity.Request;
            RegistrationNumber_TextBox.Text = request.Object.registration_number;
            BodyType_TextBox.Text = request.Object.body_type;
            Name_TextBox.Text = request.Object.name;
            Engine_TextBox.Text = request.Object.engine;
            Manufacturer_TextBox.Text = request.Object.manufacturer;
            Year_TextBox.Text = request.Object.year.ToString();
            Model_TextBox.Text = request.Object.model;
            Other_TextBox.Text = request.Object.other;
            RequestDescription_TextBox.Text = request.description;
            ActivityDescription_TextBox.Text = activity.description;
            Date_TextBox.Text = activity.date_fin_cancel.ToString();
            Result_TextBox.Text = activity.result;

			Result_TextBox.Enabled = activity.status == "In progress";

			if (!activity.status.Contains("In progress"))
            {
                //Result_TextBox.BackColor = Color.White;
                Result_TextBox.Enabled = true;
            }
			if (activity.status.Contains("Open"))
			{
				Cancel_Button.Enabled = false;
				Finish_Button.Enabled = false;
				StartWork_Button.Enabled = true;
				Result_TextBox.Enabled = false;
			}
			else if (activity.status.Contains("In progress"))
			{
				Cancel_Button.Enabled = true;
				Finish_Button.Enabled = true;
				StartWork_Button.Enabled = false;
				Result_TextBox.Enabled = false;
			}
			else if (activity.status.Contains("Canceled") || activity.status.Contains("Finished")) 
			{
				Cancel_Button.Enabled = false;
				Finish_Button.Enabled = false;
				StartWork_Button.Enabled = false;
				Result_TextBox.Enabled = false;
			}
			Status_TextBox.Text = activity.status;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Dispose();
            Status_TextBox.Text = "Canceled";
            Result_TextBox.BackColor = Color.White;
            Result_TextBox.Enabled = true;
			Cancel_Button.Enabled =false;
			Finish_Button.Enabled =false;
			Save_Button.Enabled = true;
			Return_Button.Enabled = true;
		}

        private void StartWork_Button_Click(object sender, EventArgs e)
        {
            Status_TextBox.Text = "In progress";
            Result_TextBox.Enabled = false;
            Result_TextBox.BackColor = Status_TextBox.BackColor;
			StartWork_Button.Enabled = false;
			Cancel_Button.Enabled = true;
			Finish_Button.Enabled = true;
			Save_Button.Enabled = false;
			Return_Button.Enabled = false;
		}

		private void Finish_Button_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Dispose();
            Status_TextBox.Text = "Finished";
            Result_TextBox.BackColor = Color.White;
            Result_TextBox.Enabled = true;
			Cancel_Button.Enabled = false;
			Finish_Button.Enabled = false;
			Save_Button.Enabled = true;
			Return_Button.Enabled = true;
		}

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void UpdateStatus(string status)
        {
            activity.status = status;
            activity.result = Result_TextBox.Text;
            if((status=="Finished") || (status=="Canceled"))
            {
                activity.date_fin_cancel = System.DateTime.Now;
            }
            try
            {
                ManagerService.UpdateActivity(activity);
                Status_TextBox.Text = status;
            }
            catch(ServiceException e)
            {
                Alert.DisplayError(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStatus(Status_TextBox.Text);
            this.Close();
            this.Dispose();
        }

		private void ActivityViever_Load(object sender, EventArgs e)
		{

		}

		private void Result_TextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
