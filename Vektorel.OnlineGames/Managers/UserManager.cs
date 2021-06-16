
using Ibrahim.OnlineGames.NumberGameService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ibrahim.OnlineGames.Managers
{
    public class UserManager
    {
        private static UserManager instance;
        
        private UserManager()
        {

        }
        public static UserManager Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new UserManager();                    
                }
                return instance;
            }
        }
        public UserInfo CurrentUser { get; set; }

        public UserInfo PartnerUser { get; set; }

        public string RoomName { get; set; }

    }
}

