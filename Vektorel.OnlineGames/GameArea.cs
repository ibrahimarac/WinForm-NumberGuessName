
using Ibrahim.OnlineGames.Managers;
using Ibrahim.OnlineGames.NumberGameService;
using Ibrahim.OnlineGames.Room;
using Ibrahim.OnlineGames.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ibrahim.OnlineGames
{
    public partial class GameArea : Form
    {
        Ibrahim.OnlineGames.NumberGameService.GameServiceClient proxy = new Ibrahim.OnlineGames.NumberGameService.GameServiceClient();
        List<AttackInfo> partnerAttacks = new List<AttackInfo>();

        public GameArea(string guess)
        {
            InitializeComponent();
            lblNumber.Text = guess;
            groupYou.Text = UserManager.Instance.CurrentUser.UserName;
        }

        private void GameArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageInfo result = proxy.LeaveRoom(UserManager.Instance.RoomName, 
                UserManager.Instance.CurrentUser);
            /*
                   Windows uygulamamızda oyuna ait bilgileri sakladığımız UserManager
                   isimli sınıfta RoomName ve PartnerUser isimli özellikleri sıfırlayalım.
            */
            UserManager.Instance.PartnerUser = null;
            UserManager.Instance.RoomName = "";
            timer1.Stop();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            AttackInfo attackResult = proxy.SendAttack(
                UserManager.Instance.RoomName,
                UserManager.Instance.CurrentUser,
                txtGuess.Text);
            GetResultFromUserControlToGameArea(flowYourArea, attackResult);
            proxy.ChangePlayerOrder(UserManager.Instance.RoomName);
        }

        void GetResultFromUserControlToGameArea(FlowLayoutPanel flowArea, 
            AttackInfo attackResult)
        {
            GuessObject obj = new GuessObject();
            obj.CorrectCount = attackResult.CorrectPosition;
            obj.WrongCount = attackResult.WrongPosition;
            
            //Eğer bizim hamlemiz ise
            if (flowYourArea.Name == flowArea.Name)
            {
                flowYourArea.Controls.Add(obj);
                obj.Guess = txtGuess.Text;
            }
            else if (flowArea.Name == flowYourFriendArea.Name)
            {
                flowYourFriendArea.Controls.Add(obj);
                obj.Guess = attackResult.Guess;
            }
        }
        
        void GetPartnerUser()
        {
            if (UserManager.Instance.PartnerUser == null)
            {
                MessageInfo result = proxy.GetPartnerForUser(UserManager.Instance.RoomName, UserManager.Instance.CurrentUser);
                if (result.Data != null)
                {
                    UserManager.Instance.PartnerUser = result.Data as UserInfo;                    
                }
            }
            else
            {
                groupPartner.Text = UserManager.Instance.PartnerUser.UserName;
            }            
        }

        void CheckPartnerIsOnline()
        {
            if (UserManager.Instance.PartnerUser == null)
                return;
            if (groupPartner.Text == "")
                groupPartner.Text = UserManager.Instance.PartnerUser.UserName;
            /*
                Eğer rakip oyuncu tepki vermiyorsa oyuncumuzu da oyundan çıkaralım.
                Oyuncumuzu oyundan atarak bu formu kapatıyoruz. Bu formu kapatırsak
                oyuncumuzda LeaveRoom metodu sayesinde oyundan  çıkarılmış oluyor.
            */
            if (!proxy.UserActivityTest(UserManager.Instance.RoomName, 
                UserManager.Instance.PartnerUser))
            {
                MessageBox.Show("Rakibinizin oyundan ayrıldı. Lütfen farklı bir oyun seçiniz.");
                /*
                    Bu oyundan ayrıldığımıza göre SelectRoom formunu seçerek kullanıcıyı 
                    bu forma yönlendirelim. 
                */
                SelectRoom selectRoom = new SelectRoom();
                selectRoom.ShowDialog();
                this.Close();
            }
        }

        void CheckPlayerOrder()
        {
            UserInfo orderedPlayer =
                proxy.GetUserOrderForRoom(UserManager.Instance.RoomName);

            if (orderedPlayer.UserName==UserManager.Instance.CurrentUser.UserName)
            {
                groupSendGuess.Visible = true;
                groupGetGuess.Visible = false;
            }
            else if (orderedPlayer.UserName == UserManager.Instance.PartnerUser.UserName)
            {
                groupGetGuess.Visible = true;
                groupSendGuess.Visible = false;
            }

        }

        void GetLastAttackForPartner()
        {
            AttackInfo lastAttackFromService =
                proxy.GetLastAttackForPartner(UserManager.Instance.PartnerUser);
            if (lastAttackFromService != null)
            {
                if(partnerAttacks.Count==0)
                {
                    partnerAttacks.Add(lastAttackFromService);
                    GetResultFromUserControlToGameArea(flowYourFriendArea, 
                        lastAttackFromService);
                }
                else if (partnerAttacks[partnerAttacks.Count - 1].AttackDate != 
                    lastAttackFromService.AttackDate)
                {
                    partnerAttacks.Add(lastAttackFromService);
                    GetResultFromUserControlToGameArea(flowYourFriendArea, 
                        lastAttackFromService);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetPartnerUser();

            if (UserManager.Instance.PartnerUser != null)
            {
                CheckPartnerIsOnline();
                CheckPlayerOrder();
                GetLastAttackForPartner();
            }            
        }
    }
}
