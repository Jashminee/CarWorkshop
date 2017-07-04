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
    public partial class AdminMainWindow : MainWindow
    {
        public AdminMainWindow(Personel user)
        {
            InitializeComponent();
			this.user = user;
            this.FormClosing += X_Clickd;
            this.Role_ComboBox.Items.AddRange(new object[] {"-", "Admin", "Manager", "Worker"});
        }

        private void X_Clickd(object sender, FormClosingEventArgs e)
        {
            //x clicked
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Program.CloseApp(sender, e);
            }
        }

        private void AdminMainWindow_Load(object sender, EventArgs e)
        {

        }

    
        public override void InitOnShow()
        {
			this.WelcomeText_Label.Text = "Hi, you are logged in as " + user.username;
			//this.WelcomeText_Label.Text = string.Format("Hi, you are logged in as [{0}]", user.username);
		}

		private void LogOut_Button_Click(object sender, EventArgs e)
        {
            Program.loginWindow.Visible = true;
            this.Visible = false;
        }

        private void AddNewAccount_Button_Click(object sender, EventArgs e)
        {
            UserEditor addNewAccountWindow = new UserEditor();
            addNewAccountWindow.ShowDialog();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {	
            if(Users_DataGridView.CurrentRow == null || (Personel)Users_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            UserEditor addNewAccountWindow = new UserEditor((Personel)Users_DataGridView.CurrentRow.DataBoundItem);
            addNewAccountWindow.ShowDialog();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Personel crit = new Personel();
            crit.first_name = Name_TextBox.Text;
            crit.last_name = Surname_TextBox.Text;
			if(Role_ComboBox.Text == "-")
				crit.role = "";
			else
				crit.role = Role_ComboBox.Text;
            IQueryable<Personel> results;
            try
            {
                if (IncludeRetire_CheckBox.Checked)
                {
                    results = AdminService.GetPersonel(crit);
                }
                else
                {
                    results = AdminService.GetPersonelActive(crit);
                }
                Users_DataGridView.Columns.Clear();
                Users_DataGridView.DataSource = results.ToList();
                CorrectGrid();
            }catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
            
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if ((Personel)Users_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                AdminService.DeletePersonel((Personel)Users_DataGridView.CurrentRow.DataBoundItem);
                int index = Users_DataGridView.CurrentRow.Index;
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[Users_DataGridView.DataSource];
                currencyManager.SuspendBinding();
                Users_DataGridView.Rows[index].Visible = false;
                currencyManager.ResumeBinding();
            }
            catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void CorrectGrid()
        {
            Users_DataGridView.Columns[0].Visible = false;
            Users_DataGridView.Columns[6].Visible = false;
            Users_DataGridView.Columns[7].Visible = false;
            Users_DataGridView.Columns[8].Visible = false;

            Users_DataGridView.Columns[1].HeaderText = "Name";
            Users_DataGridView.Columns[2].HeaderText = "Surname";
            Users_DataGridView.Columns[3].HeaderText = "Username";
            Users_DataGridView.Columns[4].HeaderText = "Date retire";
            Users_DataGridView.Columns[5].HeaderText = "Role";
        }
	}
}
