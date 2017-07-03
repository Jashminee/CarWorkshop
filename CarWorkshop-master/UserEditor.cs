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
    public partial class UserEditor : Form
    {
        private Personel user;
        public UserEditor()
        {
            InitializeComponent();
            user = null;
            this.Role_ComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Worker" });
			Date_Retire.Checked = false;
		}

        public UserEditor(Personel user)
        {
            InitializeComponent();
            this.Role_ComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Worker" });
            Name_TextBox.Text = user.first_name;
            Surname_TextBox.Text = user.last_name;
            Username_TextBox.Text = user.username;
            Role_ComboBox.Text = user.role;
			if (user.date_retire == null)
			{
				Date_Retire.Checked = false;
			}
			else
			{
				Date_Retire.Checked = true;
				Date_Retire.Value = (System.DateTime)user.date_retire;
			}
			this.user = user;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(Name_TextBox.Text)||String.IsNullOrWhiteSpace(Surname_TextBox.Text)||String.IsNullOrWhiteSpace(Username_TextBox.Text)||String.IsNullOrWhiteSpace(Role_ComboBox.Text))
            {
                Alert.DisplayError("Invalid input values!");
                return;
            }
            try
            {
                if (user == null)
                {
                    if(String.IsNullOrWhiteSpace(Password_TextBox.Text))
                    {
                        Alert.DisplayError("Invalid input values!");
                        return;
                    }
                    FillUser();
                    AdminService.NewPersonel(user);
                }
                else
                {
                    FillUser();
                    AdminService.UpdatePersonel(user);
                }
                this.Close();
                this.Dispose();
            }catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {

        }

        private void FillUser()
        {
            if(user == null)
            {
                user = new Personel();
                user.password = Password_TextBox.Text;
            }
			if (Date_Retire.Checked)
				user.date_retire = Date_Retire.Value;
			else
				user.date_retire = null;
			user.first_name = Name_TextBox.Text;
            user.last_name = Surname_TextBox.Text;
            user.username = Username_TextBox.Text;
            user.role = Role_ComboBox.Text;
			user.password = Password_TextBox.Text;
        }
    }
}
