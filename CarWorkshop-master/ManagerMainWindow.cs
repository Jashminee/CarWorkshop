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
    public partial class ManagerMainWindow : MainWindow
    {
        public ManagerMainWindow(Personel user)
        {
            InitializeComponent();
            this.user = user;

            this.FormClosing += X_Clickd;
            ActivityStatus_ComboBox.Items.AddRange(new object[] { "In progress", "Canceled", "Finished" });
            RequestStatus_ComboBox.Items.AddRange(new object[] { "In progress", "Canceled", "Finished" });
        }

        private void X_Clickd(object sender, FormClosingEventArgs e)
        {
            //x clicked
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Program.CloseApp(sender, e);
            }
        }

        private void ManagerMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.loginWindow.Visible = true;
        }

        public override void InitOnShow()
        {
            this.WelcomeText_Label.Text = "Hi, you are logged in as " + user.username;
        }

        private void AddNewCustomer_Button_Click(object sender, EventArgs e)
        {
            CustomerEditor addNewCustomerWindow = new CustomerEditor();
            addNewCustomerWindow.ShowDialog();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            //check if some row is selected
            if (Customers_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            //unpack entity from row and proceed Customer Editor
            CustomerEditor EditCustomerWindow = new CustomerEditor((Client)Customers_DataGridView.CurrentRow.DataBoundItem);
            EditCustomerWindow.ShowDialog();
        }

        private void AddObject_Button_Click(object sender, EventArgs e)
        {
            if (Customers_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            ObjectEditor objectEditor = new ObjectEditor((Client)Customers_DataGridView.CurrentRow.DataBoundItem);
            objectEditor.ShowDialog();
        }

        private void ShowObjects_Button_Click(object sender, EventArgs e)
        {
            if (Customers_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            DataLayer.Object obj = new DataLayer.Object();
            obj.id_client = ((Client)Customers_DataGridView.CurrentRow.DataBoundItem).id_client;
            GetObjects(obj);
            //change the tab
            ManagerMainWindow_TabControl.SelectedIndex = 1;
        }

        // Get object from database and display
        private void GetObjects(DataLayer.Object obj)
        {
            try
            {
                var result = ManagerService.GetObjects(obj);
				var x = result.ToList();
                Objects_DataGridView.Columns.Clear();

				var data = (from ob in result
							select new
							{
								ob.id_object,
								ob.Client.name,
								ob.Client.first_name,
								ob.Client.last_name,
								ObName = ob.name,
								ob.registration_number,
								ob.manufacturer,
								ob.model,
								ob.body_type,
								ob.year,
								ob.engine,
								ob.Object_type.name_type
							}).ToList();

				Objects_DataGridView.DataSource = data;


				Objects_DataGridView.Columns[0].Visible = false;

				Objects_DataGridView.Columns[1].HeaderText = "Company name";
				Objects_DataGridView.Columns[2].HeaderText = "Customer's name";
				Objects_DataGridView.Columns[3].HeaderText = "Customer's surname";
                Objects_DataGridView.Columns[4].HeaderText = "Name";
                Objects_DataGridView.Columns[5].HeaderText = "Registration No.";
                Objects_DataGridView.Columns[6].HeaderText = "Manufacturer";
                Objects_DataGridView.Columns[7].HeaderText = "Model";
                Objects_DataGridView.Columns[8].HeaderText = "Body type";
                Objects_DataGridView.Columns[9].HeaderText = "Year";
                Objects_DataGridView.Columns[10].HeaderText = "Engine";
                Objects_DataGridView.Columns[11].HeaderText = "Type";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void SeeDetails_Button_Click(object sender, EventArgs e)
        {
            EditObject_Button_Click(sender, e);
        }

        private void EditObject_Button_Click(object sender, EventArgs e)
        {
            if (Objects_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            DataLayer.Object obj = new DataLayer.Object();
            obj.id_object = (int)Objects_DataGridView.CurrentRow.Cells[0].Value;
            try
            {
                obj = ManagerService.GetObjects(obj).SingleOrDefault();
                ObjectEditor objectEditor = new ObjectEditor(obj);
                objectEditor.ShowDialog();
            }catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void AddRequest_Button_Click(object sender, EventArgs e)
        {
            if (Objects_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            DataLayer.Object obj = new DataLayer.Object();
            obj.id_object = (int)Objects_DataGridView.CurrentRow.Cells[0].Value;
            try
            {
                obj = ManagerService.GetObjects(obj).SingleOrDefault();
                RequestEditor requestEditor = new RequestEditor(obj);
                requestEditor.ShowDialog();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
            
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            if (Requests_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                Request request = new Request();
                request.id_request = (int)Requests_DataGridView.CurrentRow.Cells[0].Value;
                request = ManagerService.GetRequests(request).SingleOrDefault();
                RequestEditor requestEditor = new RequestEditor(request);
                requestEditor.ShowDialog();
            } catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void ShowActivity_Button_Click(object sender, EventArgs e)
        {
            if (Activities_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            Activity activity = new Activity();
            activity.id_activity = (int)Activities_DataGridView.CurrentRow.Cells[0].Value;
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

        private void SearchCustomers_Button_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if(Company_CheckBox.Checked)
            {
                client.name = CustomerName_TextBox.Text;
            }
            else
            {
                client.first_name = CustomerName_TextBox.Text;
                client.last_name = Surname_TextBox.Text;
            }
            client.city = City_TextBox.Text;
            client.country = Country_TextBox.Text;
            try
            {
                var result = ManagerService.GetClients(client);
				var result2 = result.ToList().FindAll(x =>
				{
					if (Company_CheckBox.Checked)
						return !string.IsNullOrEmpty(x.name);
					else
						return !string.IsNullOrEmpty(x.first_name);
				});

                Customers_DataGridView.Columns.Clear();
                Customers_DataGridView.DataSource = result2.ToList();
                
                if(Company_CheckBox.Checked)
                {
                    Customers_DataGridView.Columns[2].Visible = false;
                    Customers_DataGridView.Columns[3].Visible = false;
                    Customers_DataGridView.Columns[9].HeaderText = "NIP";
                }
                else
                {
                    Customers_DataGridView.Columns[1].Visible = false;
                    Customers_DataGridView.Columns[9].HeaderText = "PESEL";
                }

                Customers_DataGridView.Columns[0].Visible = false;
                Customers_DataGridView.Columns[10].Visible = false;

                Customers_DataGridView.Columns[1].HeaderText = "Name";
                Customers_DataGridView.Columns[2].HeaderText = "Name";
                Customers_DataGridView.Columns[3].HeaderText = "Surname";
                Customers_DataGridView.Columns[4].HeaderText = "City";
                Customers_DataGridView.Columns[5].HeaderText = "Street";
                Customers_DataGridView.Columns[6].HeaderText = "Number";
                Customers_DataGridView.Columns[7].HeaderText = "Flat";
                Customers_DataGridView.Columns[8].HeaderText = "Country";
            }
            catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void Objects_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchObjects_Button_Click(object sender, EventArgs e)
        {
            DataLayer.Object obj = new DataLayer.Object();
            obj.name = Name_TextBox.Text;
            obj.manufacturer = Manufacturer_TextBox.Text;
            obj.registration_number = RegistrationNo_TextBox.Text;
            obj.model = Model_TextBox.Text;
            GetObjects(obj);
        }

        private void DeleteCustomer_Button_Click(object sender, EventArgs e)
        {
            if (Customers_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                ManagerService.DeleteClient((Client)Customers_DataGridView.CurrentRow.DataBoundItem);
                int index = Customers_DataGridView.CurrentRow.Index;
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[Customers_DataGridView.DataSource];
                currencyManager.SuspendBinding();
                Customers_DataGridView.Rows[index].Visible = false;
                currencyManager.ResumeBinding();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void DeleteObject_Button_Click(object sender, EventArgs e)
        {
            if (Objects_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                DataLayer.Object obj = new DataLayer.Object();
                obj.id_object = (int)Objects_DataGridView.CurrentRow.Cells[0].Value;
                ManagerService.DeleteObject(obj);
                int index = Objects_DataGridView.CurrentRow.Index;
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[Objects_DataGridView.DataSource];
                currencyManager.SuspendBinding();
                Objects_DataGridView.Rows[index].Visible = false;
                currencyManager.ResumeBinding();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void ShowRequests_Button_Click(object sender, EventArgs e)
        {
            if (Objects_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            Request request = new Request();
            request.id_object = (int)Objects_DataGridView.CurrentRow.Cells[0].Value;
            GetRequests(request);
            ManagerMainWindow_TabControl.SelectedIndex = 2;
        }

        //fill grid view with requests
        private void GetRequests(Request request)
        {
            try
            {
                var result = ManagerService.GetRequests(request);
				var r = result.ToList();

				Requests_DataGridView.Columns.Clear();
                Requests_DataGridView.DataSource = (from el in result
                                                    select new
                                                    {
                                                        el.id_request,
                                                        el.Object.name,
                                                        el.description,
                                                        el.status,
                                                        el.result,
                                                        el.date_request,
                                                        el.date_fin_cancel,
                                                    }).ToList();

                Requests_DataGridView.Columns[0].Visible = false;

                Requests_DataGridView.Columns[1].HeaderText = "Object name";
                Requests_DataGridView.Columns[2].HeaderText = "Description";
                Requests_DataGridView.Columns[3].HeaderText = "Status";
                Requests_DataGridView.Columns[4].HeaderText = "Result";
                Requests_DataGridView.Columns[5].HeaderText = "Date request";
                Requests_DataGridView.Columns[6].HeaderText = "Date finish";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void SearchRequests_Button_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            if(RequestDate_DateTimePicker.Checked)
            {
                request.date_request = RequestDate_DateTimePicker.Value;
            }
            request.status = RequestStatus_ComboBox.Text;
            GetRequests(request);
        }

        private void SearchActivities_Button_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            if(ActivityDate_DateTimePicker.Checked)
            {
                activity.date_request = ActivityDate_DateTimePicker.Value;
            }
            activity.status = ActivityStatus_ComboBox.Text;
            if(ShowOnlyMyActivities_CheckBox.Checked)
            {
                activity.id_personel = user.id_personel;
            }
			activity.description = ActivityName_TextBox.Text;
			GetActivities(activity);
        }
        
        private void GetActivities(Activity activity)
        {
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

        private void DeleteRequest_Button_Click(object sender, EventArgs e)
        {
            if (Requests_DataGridView.CurrentRow == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                Request request = new Request();
                request.id_request = (int)Requests_DataGridView.CurrentRow.Cells[0].Value;
                request = ManagerService.GetRequests(request).SingleOrDefault();
                ManagerService.DeleteRequest(request);
                int index = Requests_DataGridView.CurrentRow.Index;
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[Requests_DataGridView.DataSource];
                currencyManager.SuspendBinding();
                Requests_DataGridView.Rows[index].Visible = false;
                currencyManager.ResumeBinding();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

		private void ActivityPreviousDay_Button_Click(object sender, EventArgs e)
		{
			ActivityDate_DateTimePicker.Value -= TimeSpan.FromDays(1);
		}

		private void ActivityNextDay_Button_Click(object sender, EventArgs e)
		{
			ActivityDate_DateTimePicker.Value += TimeSpan.FromDays(1);
		}
	}
}
