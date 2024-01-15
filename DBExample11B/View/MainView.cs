using DBExample11B.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBExample11B.View
{
    public partial class MainView : Form
    {
        MainController mainController = new MainController();

        public MainView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtAccount.Text;
            var password = txtPassword.Text;

            var isRegistered = mainController.CheckLogin(username, password);
            if(isRegistered)
            {
                LoginView loginView = new LoginView();
                loginView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }
    }
}
