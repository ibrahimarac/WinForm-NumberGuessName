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
    public partial class CreateRoom : Form
    {
        GameServiceClient proxy = new GameServiceClient();
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            MessageInfo result= proxy.CreateRoom(txtRoomName.Text);
            if(result.Result==Status.Error)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                RoomInfo room = result.Data as RoomInfo;                
                this.Close();
            }
        }
    }
}
