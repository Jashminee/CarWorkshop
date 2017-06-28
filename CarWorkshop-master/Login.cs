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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Program.loginWindow = this;
            this.AcceptButton = Login_Button;
            this.FormClosing += Program.CloseApp;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            
            Personel user = new Personel();
            user.password = Password_TextBox.Text;
            user.username = Username_TextBox.Text;
            try
            {
                var result = AdminService.GetPersonelWithPassword(user);
                if(result==null)
                {
                    Alert.DisplayError("Invalid username or password!");
                    return;
                }
                MainWindow mainWindow;
                if (result.role.StartsWith("Admin"))
                {
                    mainWindow = new AdminMainWindow();
                } else if (result.role.StartsWith("Manager"))
                {
                    mainWindow = new ManagerMainWindow(result);
                } else
                {
                    mainWindow = new WorkerMainWindow(result);
                }

                Program.mainWindow = mainWindow;
                mainWindow.InitOnShow();

                this.Visible = false;
                mainWindow.ShowDialog();
                /*
                string adminText = "admin";
                string managerText = "manager";
                //this.Username_TextBox.Text = managerText;
                MainWindow mainWindow;
                if (this.Username_TextBox.Text == adminText)
                {
                    mainWindow = new AdminMainWindow();
                }
                else if (this.Username_TextBox.Text == managerText)
                {
                    mainWindow = new ManagerMainWindow(new DataLayer.Personel());    
                }
                else
                {
                    mainWindow = new WorkerMainWindow(new DataLayer.Personel());
                }
                Program.mainWindow = mainWindow;
                mainWindow.InitOnShow();

                this.Visible = false;
                mainWindow.ShowDialog();
                */
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }
    }
}
