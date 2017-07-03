using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace CarWorkshop
{
    public partial class WorkerMainWindow : MainWindow
    {
        Personel user;
        public WorkerMainWindow(Personel user)
        {
            InitializeComponent();

            this.FormClosing += X_Clickd;
            Status_ComboBox.Items.AddRange(new object[] {"-", "In progress", "Canceled", "Finished" });
            this.user = user;
        }

        private void X_Clickd(object sender, FormClosingEventArgs e)
        {
            //x clicked
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Program.CloseApp(sender, e);
            }
        }

        public override void InitOnShow()
        {
            this.WelcomeText_Label.Text = "Hi, you are logged in as " + user.username;
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            Program.loginWindow.Visible = true;
            this.Visible = false;
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            if (Activity_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            Activity activity = new Activity();
            activity.id_activity = (int)Activity_DataGridView.CurrentRow.Cells[0].Value;
            try
            {
                activity = ManagerService.GetActivities(activity).SingleOrDefault();
                ActivityViever activityViever = new ActivityViever(activity);
                activityViever.ShowDialog();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.id_personel = user.id_personel;
            activity.date_fin_cancel = DateTimePicker.Value;
			if (Status_ComboBox.Text == "-")
				activity.status = Status_ComboBox.Text;
			else
				activity.status = Status_ComboBox.Text;
			try
            {
                var result = ManagerService.GetActivities(activity);
                Activity_DataGridView.Columns.Clear();
                Activity_DataGridView.DataSource = (from el in result
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

                Activity_DataGridView.Columns[0].Visible = false;

                Activity_DataGridView.Columns[1].HeaderText = "Seq Nr";
                Activity_DataGridView.Columns[2].HeaderText = "Description";
                Activity_DataGridView.Columns[3].HeaderText = "Type";
                Activity_DataGridView.Columns[4].HeaderText = "Date";
                Activity_DataGridView.Columns[5].HeaderText = "Date finish";
                Activity_DataGridView.Columns[6].HeaderText = "Status";
                Activity_DataGridView.Columns[7].HeaderText = "Result";
            } catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }
    }
}
