
using Ibrahim.OnlineGames.Managers;
using Ibrahim.OnlineGames.NumberGameService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ibrahim.OnlineGames.Room
{
   

    public partial class SelectRoom : Form
    {
        GameServiceClient proxy = new GameServiceClient();

        public SelectRoom()
        {
            InitializeComponent();
        }
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            CreateRoom creaeteRoom = new CreateRoom();
            creaeteRoom.ShowDialog();
        }
        void BindRoomList()
        {
            dgRoomList.AutoGenerateColumns = false;

            var roomList = proxy.GetAllEmptyRooms(UserManager.Instance.CurrentUser);
            var model = (from m in roomList
                        select new RoomModel
                        {
                            RoomName = m.Name,
                            UserName = (m.User1 != null) ? 
                                m.User1.UserName : (m.User2!=null)?m.User2.UserName:"No Connected User",
                            User= (m.User1 != null) ? m.User1 : m.User2
                        }).ToList();
            dgRoomList.DataSource = model;
        }

        private void SelectRoom_Activated(object sender, EventArgs e)
        {
            BindRoomList();
        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            if(txtGuess.Text==""||txtGuess.Text.Length!=4)
            {
                MessageBox.Show("Please Type A Number that has four digit");
                return;
            }           
            var room = dgRoomList.SelectedRows[0].DataBoundItem as RoomModel;

            var result= proxy.JoinRoom(room.RoomName,UserManager.Instance.CurrentUser,txtGuess.Text);

            if (result.Result == Status.Error)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                UserManager.Instance.RoomName = room.RoomName;
                UserManager.Instance.PartnerUser = room.User;
                GameArea gameArea = new GameArea(txtGuess.Text);
                gameArea.ShowDialog();
            }            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindRoomList();
        }
    }
    class RoomModel
    {
        public string RoomName { get; set; }
        public string UserName { get; set; }
        public UserInfo User { get; set; }
    }

}

