
using Ibrahim.OnlineGames.Managers;
using Ibrahim.OnlineGames.NumberGameService;
using Ibrahim.OnlineGames.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ibrahim.OnlineGames.Login
{
    public partial class LoginForm : Form
    {
        GameServiceClient proxy = new GameServiceClient();

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            frm.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = proxy.LogIn(txtUserName.Text, txtPassword.Text);
            if (result.Result == Status.Error)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                var user = result.Data as UserInfo;
                UserManager.Instance.CurrentUser = user;
                SelectRoom roomList = new SelectRoom();
                roomList.ShowDialog();
            }
        }
    }
}
