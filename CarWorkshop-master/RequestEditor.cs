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
    public partial class RequestEditor : Form
    {
        private Request request = null;
        private DataLayer.Object obj = null;
        public RequestEditor(DataLayer.Object obj)
        {
            InitializeComponent();
            this.obj = obj;
            BodyType_TextBox.Text = obj.body_type;
            Name_TextBox.Text = obj.name;
            Engine_TextBox.Text = obj.engine;
            Manufacturer_TextBox.Text = obj.manufacturer;
            Year_TextBox.Text = obj.year.ToString();
            Model_TextBox.Text = obj.model;
            Other_TextBox.Text = obj.other;
            RegistrationNumber_TextBox.Text = obj.registration_number;
            Status_TextBox.Text = "In progress";

            AddActivity_Button.Enabled = false;
            DeleteActivity_Button.Enabled = false;
            WorkInProgres_GroupBox.Enabled = false;

			Save_Button.Text = "Save Request";
        }

        public RequestEditor(Request request)
        {
            InitializeComponent();
            this.request = request;
            RegistrationNumber_TextBox.Text = request.Object.registration_number;
            BodyType_TextBox.Text = request.Object.body_type;
            Name_TextBox.Text = request.Object.name;
            Engine_TextBox.Text = request.Object.engine;
            Manufacturer_TextBox.Text = request.Object.manufacturer;
            Year_TextBox.Text = request.Object.year.ToString();
            Model_TextBox.Text = request.Object.model;
            Other_TextBox.Text = request.Object.other;
            Description_TextBox.Text = request.description;
            Status_TextBox.Text = request.status;
            if(request.status!="In progress")
            {
               Result_textBox.BackColor = Color.White;
               Result_textBox.Enabled = true;
            }

            Activity activity = new Activity();
            activity.id_request = request.id_request;
            try
            {
                var result = ManagerService.GetActivities(activity);
                Activities_DataGridView.Columns.Clear();
                Activities_DataGridView.DataSource = (from el in result select new
                {
                    el.id_activity,
                    el.seq_no,
                    el.description,
                    el.Act_dict.act_name,
                    el.date_request,
                    el.date_fin_cancel,
                    el.status,
                    el.result
                }).ToList();

                Activities_DataGridView.Columns[0].Visible = false;

                Activities_DataGridView.Columns[1].HeaderText = "Seq Nr";
                Activities_DataGridView.Columns[2].HeaderText = "Description";
                Activities_DataGridView.Columns[3].HeaderText = "Type";
                Activities_DataGridView.Columns[4].HeaderText = "Date";
                Activities_DataGridView.Columns[5].HeaderText = "Date finish";
                Activities_DataGridView.Columns[6].HeaderText = "Status";
                Activities_DataGridView.Columns[7].HeaderText = "Result";

				Save_Button.Text = "Save and Quit";
			}
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void AddActivity_Button_Click(object sender, EventArgs e)
        {
            ActivityEditor activityEditor = new ActivityEditor(request);
            activityEditor.ShowDialog();
            Activity activity = new Activity();
            activity.id_request = request.id_request;
            try
            {
                var result = ManagerService.GetActivities(activity);
                Activities_DataGridView.Columns.Clear();
                Activities_DataGridView.DataSource = (from el in result select new
                {
                    el.id_activity,
                    el.seq_no,
                    el.description,
                    el.Act_dict.act_name,
                    el.date_request,
                    el.date_fin_cancel,
                    el.status,
                    el.result
                }).ToList();

                Activities_DataGridView.Columns[0].Visible = false;

                Activities_DataGridView.Columns[1].HeaderText = "Seq Nr";
                Activities_DataGridView.Columns[2].HeaderText = "Description";
                Activities_DataGridView.Columns[3].HeaderText = "Type";
                Activities_DataGridView.Columns[4].HeaderText = "Date";
                Activities_DataGridView.Columns[5].HeaderText = "Date finish";
                Activities_DataGridView.Columns[6].HeaderText = "Status";
                Activities_DataGridView.Columns[7].HeaderText = "Result";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(request==null)
                {
                    request = new Request();
                    request.description = Description_TextBox.Text;
                    request.id_object = obj.id_object;
                    request.status = Status_TextBox.Text;
                    request.result = Result_textBox.Text;
					request.id_personel = Login.LoggedUser.id_personel;
					request.date_request = System.DateTime.Now;
                    ManagerService.NewRequest(request);
                    AddActivity_Button.Enabled = true;
                    DeleteActivity_Button.Enabled = true;
                    WorkInProgres_GroupBox.Enabled = true;
					Save_Button.Text = "Save and Quit";
                }else
                {
                    request.description = Description_TextBox.Text;
                    request.status = Status_TextBox.Text;
                    request.result = Result_textBox.Text;
                    if ((request.status == "Finished") || (request.status == "Canceled"))
                    {
                        request.date_fin_cancel = System.DateTime.Now;
                    }
                    ManagerService.UpdateRequest(request);
                    this.Close();
                    this.Dispose();
                }
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void MoveDown_Button_Click(object sender, EventArgs e)
        {

        }

        private void MoveUp_Button_Click(object sender, EventArgs e)
        {

        }

        private void DeleteActivity_Button_Click(object sender, EventArgs e)
        {
            if (Activities_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                Activity activity = new Activity();
                activity.id_activity = (int)Activities_DataGridView.CurrentRow.Cells[0].Value;
                activity = ManagerService.GetActivities(activity).SingleOrDefault();
                ManagerService.DeleteActivity(activity);
                int index = Activities_DataGridView.CurrentRow.Index;
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[Activities_DataGridView.DataSource];
                currencyManager.SuspendBinding();
                Activities_DataGridView.Rows[index].Visible = false;
                currencyManager.ResumeBinding();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void WorkInProgres_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status_TextBox.Text = "Canceled";
            Result_textBox.BackColor = Color.White;
            Result_textBox.Enabled = true;
        }

        private void StartWork_Button_Click(object sender, EventArgs e)
        {
            Status_TextBox.Text = "In progress";
            Result_textBox.Enabled = false;
            Result_textBox.BackColor = Status_TextBox.BackColor;
        }

        private void Finish_Button_Click(object sender, EventArgs e)
        {
            Status_TextBox.Text = "Finished";
            Result_textBox.BackColor = Color.White;
            Result_textBox.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowActivity_Button_Click(object sender, EventArgs e)
        {
            if (Activities_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                Activity activity = new Activity();
                activity.id_activity = (int)Activities_DataGridView.CurrentRow.Cells[0].Value;
                activity = ManagerService.GetActivities(activity).SingleOrDefault();
                ActivityEditor activityEditor = new ActivityEditor(ManagerService.GetActivities(activity).SingleOrDefault());
                activityEditor.ShowDialog();
                activity = new Activity();
                activity.id_request = request.id_request;
                var result = ManagerService.GetActivities(activity);
                Activities_DataGridView.Columns.Clear();
                Activities_DataGridView.DataSource = (from el in result
                                                      select new
                                                      {
                                                          el.id_activity,
                                                          el.seq_no,
                                                          el.description,
                                                          el.Act_dict.act_name,
                                                          el.date_request,
                                                          el.date_fin_cancel,
                                                          el.status,
                                                          el.result
                                                      }).ToList();

                Activities_DataGridView.Columns[0].Visible = false;

                Activities_DataGridView.Columns[1].HeaderText = "Seq Nr";
                Activities_DataGridView.Columns[2].HeaderText = "Description";
                Activities_DataGridView.Columns[3].HeaderText = "Type";
                Activities_DataGridView.Columns[4].HeaderText = "Date";
                Activities_DataGridView.Columns[5].HeaderText = "Date finish";
                Activities_DataGridView.Columns[6].HeaderText = "Status";
                Activities_DataGridView.Columns[7].HeaderText = "Result";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }
    }
}
