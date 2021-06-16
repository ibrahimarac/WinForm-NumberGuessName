
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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ibrahim.OnlineGames.Login
{
    public partial class SignInForm : Form
    {
        GameServiceClient proxy = new GameServiceClient();
        public SignInForm()
        {
            InitializeComponent();
        }      

        bool ValidateInput()
        {
            if (txtUserName.Text == "" || txtPassword.Text == "" ||
                txtPasswordAgain.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Some inputs are missing.");
                return false;
            }
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("Password and PasswordAgain field is not match.");
                return false;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Email adress is not correct format.");
                return false;
            }
            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            /*
                Eğer tüm inputlar eksiksiz girildiyse 
            */
            if (ValidateInput())
            {
                MessageInfo result= proxy.SignUp(txtUserName.Text, 
                    txtPassword.Text, txtEmail.Text);
                /*
                    Kullanıcı eklenirken bir hata oluştuysa 
                */
                if (result.Result==Status.Error)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    /*
                        Kullanıcı başarıyla oluşturuldu.Kullanıcı bilgilerini sakla
                        Oyun alanına geç
                    */
                    UserManager.Instance.CurrentUser = result.Data as UserInfo;
                    this.Close();
                    SelectRoom selectRoom = new SelectRoom();
                    selectRoom.ShowDialog();
                }
            }
        }
    }
}
